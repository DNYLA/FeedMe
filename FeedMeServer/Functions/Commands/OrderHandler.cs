using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using FeedMeServer.Functions.Commands.Stripe;
using FeedMeServer.Functions.Data;
using FeedMeServer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;

namespace FeedMeServer.Functions.Commands
{
    internal class OrderHandler
    {
        private Client clientInf;

        /// <summary>
        /// Gets Specific Order requested by client and calls the correct method
        /// </summary>
        /// <param name="clientM">Client Object by reference as token needs to be updated</param>
        public void HandleOrder(ref Client clientM)
        {
            clientInf = clientM;

            Socket client = clientM.ClientSocket;

            string specificCommand = Receive.ReceiveMessage(client); //Get Command From Client

            //Calls Method based on command
            switch (specificCommand)
            {
                case "ConfirmOrder":
                    CheckOrder();
                    break;
                case "CheckForOrder":
                    CheckForOrders();
                    break;
                case "GetSpecificOrder":
                    GetSpecificOrder();
                    break;
                case "UpdateOrderStatus":
                    UpdateOrderStatus();
                    break;
                case "UpdateRefundStatus":
                    UpdateRefundStatus();
                    break;
                case "GetCustomerOrder":
                    GetCustomerOrder();
                    break;
                case "GetRefunds":
                    GetRefunds();
                    break;
            }
        }

        /// <summary>
        /// Gets New Order from client
        /// </summary>
        private void CheckOrder()
        {
            OrderInfo orderInfo = Receive.ReceiveOrderInfo(clientInf.ClientSocket);
            UserInfo userDetails = Receive.ReceiveUserInfo(clientInf.ClientSocket);
            Send.SendMessage(clientInf.ClientSocket, AddOrderToDB(orderInfo, userDetails).ToString());
        }

        /// <summary>
        /// Adds new Order to database
        /// </summary>
        /// <param name="orderInfo">OrderInfo Object which has order information in it</param>
        /// <param name="userDetails">User Object which includes information about the customer who purchased the order</param>
        /// <returns></returns>
        private static int AddOrderToDB(OrderInfo orderInfo, UserInfo userDetails)
        {
            bool cardValid = ChargeCard.CheckCard(orderInfo); //Checks if Card Is Valid

            if (!cardValid)
            {
                return 0; //If Invalid Return;
            }

            //Insert Order Into Database
            DAL.ExecCommand($"INSERT INTO `order` (CustomerID, VendorID) VALUES ({userDetails.UserID}, {orderInfo.VendorID})");
            DataTable IdDT = DAL.ExecCommand($"SELECT id FROM `order` WHERE `CustomerID` = {userDetails.UserID} ORDER BY id DESC LIMIT 1");
            int OrderID = Convert.ToInt32(IdDT.Rows[0][0]);

            //Inserts Each Item Into Item Table
            foreach (ItemModel Item in orderInfo.Items)
            {
                string SQLQuery = ($"INSERT INTO `orderline` (OrderID, ItemID, Quantity) VALUES ({OrderID}, {Item.ItemID}, {Item.Quantity})");
                DAL.ExecCommand(SQLQuery);
            }

            if (DAL.ErrorCode != -1)
            {
                return 1; //If No errors occured return 1;
            }

            return 2;
        }

        /// <summary>
        /// Checks for order from a vendor
        /// </summary>
        internal void CheckForOrders()
        { 
            string venID = Receive.ReceiveMessage(clientInf.ClientSocket);

            string status = Receive.ReceiveMessage(clientInf.ClientSocket);

            //Gets all orders from vendor
            string sqlQuery = $"SELECT ID, CustomerID, VendorID, status, username FROM `order`, users WHERE VendorID = {venID} AND status = '{status}' AND userID = CustomerID;";
            DataTable DT = DAL.ExecCommand(sqlQuery);

            Send.SendMessage(clientInf.ClientSocket, DT.Rows.Count.ToString());

            //Loops through each order from the vendor
            foreach (DataRow Order in DT.Rows)
            {
                //Creates Order Information
                OrderInfo OI = new OrderInfo();
                OI.OrderID = Convert.ToInt32(Order[0]);
                OI.VendorID = Convert.ToInt32(Order[2]);
                OI.CustomerName = Order[4].ToString();
                Console.WriteLine(OI.CustomerName);
                OI.Items = new List<ItemModel>();
                int OrderID = Convert.ToInt32(Order[0]);

                //Loops through each item for an order
                DataTable orderInfo = DAL.ExecCommand($"SELECT * FROM `orderline` WHERE OrderID = {OrderID}");
                foreach (DataRow OrderItem in orderInfo.Rows)
                {
                    //Creates Item Information
                    ItemModel ItemInfo = new ItemModel();
                    DataTable Item = DAL.ExecCommand($"SELECT * FROM items WHERE ItemID = {Convert.ToInt32(OrderItem[2])}");
                    Console.WriteLine($"SELECT * FROM items WHERE ItemID = {Convert.ToInt32(OrderItem[2])}");

                    ItemInfo.ItemID = Convert.ToInt32(Item.Rows[0][0].ToString());
                    ItemInfo.VendorID = Convert.ToInt32(Item.Rows[0][1].ToString());
                    ItemInfo.Name = Item.Rows[0][2].ToString();
                    ItemInfo.Type = Item.Rows[0][3].ToString();
                    ItemInfo.Description = Item.Rows[0][4].ToString();
                    ItemInfo.Quantity = Convert.ToInt32(OrderItem[3]);
                    ItemInfo.Price = Convert.ToDecimal(Item.Rows[0][5].ToString());
                    ItemInfo.TotalPrice = ItemInfo.Price * ItemInfo.Quantity;

                    try
                    {
                        OI.Items.Add(ItemInfo); //Adds Item To Order Info
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                //Loops Through each Item And Calculates Price
                foreach (ItemModel Item in OI.Items)
                {
                    OI.TotalPrice += Item.TotalPrice; 
                }

                Send.SendOrderDetails(clientInf.ClientSocket, OI);
            }
        }

        /// <summary>
        /// Gets A Specific Order from the database
        /// </summary>
        internal void GetSpecificOrder()
        {
            string orderID = Receive.ReceiveMessage(clientInf.ClientSocket);

            string sqlQuery = $"SELECT ID, CustomerID, VendorID, STATUS, firstname, lastname, refunded, refundMessage FROM `order`, `users` WHERE ID = {orderID};";

            DataTable DT = DAL.ExecCommand(sqlQuery);

            DataRow Order = DT.Rows[0];
            OrderInfo OI = new OrderInfo();
            OI.VendorID = Convert.ToInt32(Order[2]);
            OI.CustomerName = Order[4].ToString() + Order[5].ToString();
            OI.Items = new List<ItemModel>();
            OI.refundStatus = Order[6].ToString();
            OI.refundMessage = Order[7].ToString();

            DataTable orderInfo = DAL.ExecCommand($"SELECT * FROM `orderline` WHERE OrderID = {orderID}");

            Console.WriteLine($"SELECT * FROM `orderline` WHERE OrderID = {orderID}; //5");

            //Loops through each Item for the order
            foreach (DataRow OrderItem in orderInfo.Rows)
            {
                ItemModel ItemInfo = new ItemModel();
                DataTable Item = DAL.ExecCommand($"SELECT * FROM items WHERE ItemID = {Convert.ToInt32(OrderItem[2])}");

                Console.WriteLine($"SELECT * FROM items WHERE ItemID = {Convert.ToInt32(OrderItem[2])}; //5");

                ItemInfo.ItemID = Convert.ToInt32(Item.Rows[0][0].ToString());
                ItemInfo.VendorID = Convert.ToInt32(Item.Rows[0][1].ToString());
                ItemInfo.Name = Item.Rows[0][2].ToString();
                ItemInfo.Type = Item.Rows[0][3].ToString();
                ItemInfo.Description = Item.Rows[0][4].ToString();
                ItemInfo.Quantity = Convert.ToInt32(OrderItem[3]);
                ItemInfo.Price = Convert.ToDecimal(Item.Rows[0][5].ToString());
                ItemInfo.TotalPrice = ItemInfo.Price * ItemInfo.Quantity;

                try
                {
                    OI.Items.Add(ItemInfo);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //Calculates Price of order
            foreach (ItemModel Item in OI.Items)
            {
                OI.TotalPrice += Item.TotalPrice;
            }

            Send.SendOrderDetails(clientInf.ClientSocket, OI);
        }

        internal static void CreateReview(Socket cSock)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates Refund Status
        /// </summary>
        internal void UpdateRefundStatus()
        {
            string orderID = Receive.ReceiveMessage(clientInf.ClientSocket);

            string refundStatus = Receive.ReceiveMessage(clientInf.ClientSocket);

            DAL.ExecCommand($"UPDATE `order` SET `refunded` = '{refundStatus}' WHERE `ID` = {orderID};");
        }

       
        /// <summary>
        /// Gets a List of All refunds that haven't been processed yet
        /// </summary>
        internal void GetRefunds()
        {
            string sqlQuery = $"SELECT * FROM `order` WHERE refunded = 'Processing'";

            DataTable custOrders = DAL.ExecCommand(sqlQuery);

            Send.SendMessage(clientInf.ClientSocket, custOrders.Rows.Count.ToString());

            foreach (DataRow order in custOrders.Rows)
            {
                OrderInfo curOrder = new OrderInfo();
                curOrder.OrderID = Convert.ToInt32(order[0]);
                curOrder.VendorID = Convert.ToInt32(order[2]);


                DataTable DT = DAL.ExecCommand($"SELECT Name FROM vendors WHERE vendorID = {order[2].ToString()}");


                curOrder.VendorName = DT.Rows[0][0].ToString();
                curOrder.StartPurchase = "10/10/11 20:30";
                curOrder.EndPurchase = "10/10/11 21:30";
                curOrder.refundStatus = order[4].ToString();
                curOrder.refundMessage = order[5].ToString();
                Send.SendOrderDetails(clientInf.ClientSocket, curOrder);
            }
        }

        /// <summary>
        /// Updates Order Status
        /// </summary>
        internal void UpdateOrderStatus()
        {
            string orderID = Receive.ReceiveMessage(clientInf.ClientSocket);

            string orderStatus = Receive.ReceiveMessage(clientInf.ClientSocket);

            DAL.ExecCommand($"UPDATE `order` SET `status` = '{orderStatus}' WHERE `ID` = {orderID};");
        }

        /// <summary>
        /// Gets all orders from a Customer
        /// </summary>
        internal void GetCustomerOrder()
        {
            string custID = Receive.ReceiveMessage(clientInf.ClientSocket);

            string sqlQuery = $"SELECT * FROM `order` WHERE CustomerID = {custID}";

            DataTable custOrders = DAL.ExecCommand(sqlQuery);

            List<OrderInfo> OIList = new List<OrderInfo>();

            Send.SendMessage(clientInf.ClientSocket, custOrders.Rows.Count.ToString());

            Console.WriteLine(custOrders.Rows.Count.ToString() + "THERE IS THAT MUANY");
            foreach (DataRow order in custOrders.Rows)
            {
                OrderInfo curOrder = new OrderInfo();
                curOrder.OrderID = Convert.ToInt32(order[0]);
                curOrder.VendorID = Convert.ToInt32(order[2]);

                
                DataTable DT = DAL.ExecCommand($"SELECT Name FROM vendors WHERE vendorID = {order[2].ToString()}");


                curOrder.VendorName = DT.Rows[0][0].ToString();
                curOrder.StartPurchase = "10/10/11 20:30";
                curOrder.EndPurchase = "10/10/11 21:30";
                Send.SendOrderDetails(clientInf.ClientSocket, curOrder);
            }
        }


    }
}
using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using FeedMeServer.Functions.Commands.Stripe;
using FeedMeServer.Functions.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;

namespace FeedMeServer.Functions.Commands
{
    internal class OrderHandler
    {
        public static void CheckOrder(Socket Client)
        {
            OrderInfo orderInfo = Receive.ReceiveOrderInfo(Client);
            UserInfo userDetails = Receive.ReceiveUserInfo(Client);
            Send.SendMessage(Client, AddOrderToDB(orderInfo, userDetails).ToString());
        }

        private static int AddOrderToDB(OrderInfo orderInfo, UserInfo userDetails)
        {
            bool cardValid = ChargeCard.CheckCard(orderInfo);

            if (!cardValid)
            {
                Console.WriteLine("Card Invalid");
                return 0;
            }

            DAL.ExecCommand($"INSERT INTO `order` (CustomerID, VendorID) VALUES ({userDetails.UserID}, {orderInfo.VendorID})");
            DataTable IdDT = DAL.ExecCommand($"SELECT id FROM `order` WHERE `CustomerID` = {userDetails.UserID} ORDER BY id DESC LIMIT 1");
            int OrderID = Convert.ToInt32(IdDT.Rows[0][0]);

            foreach (ItemModel Item in orderInfo.Items)
            {
                string SQLQuery = ($"INSERT INTO `orderline` (OrderID, ItemID, Quantity) VALUES ({OrderID}, {Item.ItemID}, {Item.Quantity})");
                DAL.ExecCommand(SQLQuery);
            }

            if (DAL.ErrorCode != -1)
            {
                return 1;
            }

            return 2;
        }

        internal static void CheckForOrders(Socket clientSocket)
        {
            string venID = Receive.ReceiveMessage(clientSocket);

            string sqlQuery = $"SELECT ID, CustomerID, VendorID, status, username FROM `order`, users WHERE VendorID = {venID} AND status = 'processing' AND userID = CustomerID;";
            DataTable DT = DAL.ExecCommand(sqlQuery);

            Console.WriteLine(sqlQuery);

            Send.SendMessage(clientSocket, DT.Rows.Count.ToString());

            foreach (DataRow Order in DT.Rows)
            {
                OrderInfo OI = new OrderInfo();
                OI.OrderID = Convert.ToInt32(Order[0]);
                OI.VendorID = Convert.ToInt32(Order[2]);
                OI.CustomerName = Order[4].ToString();
                Console.WriteLine(OI.CustomerName);
                OI.Items = new List<ItemModel>();
                int OrderID = Convert.ToInt32(Order[0]);

                DataTable orderInfo = DAL.ExecCommand($"SELECT * FROM `orderline` WHERE OrderID = {OrderID}");
                foreach (DataRow OrderItem in orderInfo.Rows)
                {
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
                        OI.Items.Add(ItemInfo);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                foreach (ItemModel Item in OI.Items)
                {
                    OI.TotalPrice += Item.TotalPrice;
                }

                Send.SendOrderDetails(clientSocket, OI);
            }
        }

        internal static void GetSpecificOrder(Socket clientSocket)
        {
            string orderID = Receive.ReceiveMessage(clientSocket);

            string sqlQuery = $"SELECT ID, CustomerID, VendorID, STATUS, firstname, lastname FROM `order`, `users` WHERE ID = {orderID};";
            Console.WriteLine(sqlQuery + "5");
            DataTable DT = DAL.ExecCommand(sqlQuery);

            Console.WriteLine(DT.Rows.Count.ToString());

            DataRow Order = DT.Rows[0];
            OrderInfo OI = new OrderInfo();
            OI.VendorID = Convert.ToInt32(Order[2]);
            OI.CustomerName = Order[4].ToString() + Order[5].ToString();
            OI.Items = new List<ItemModel>();

            DataTable orderInfo = DAL.ExecCommand($"SELECT * FROM `orderline` WHERE OrderID = {orderID}");

            Console.WriteLine($"SELECT * FROM `orderline` WHERE OrderID = {orderID}; //5");

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

            foreach (ItemModel Item in OI.Items)
            {
                OI.TotalPrice += Item.TotalPrice;
            }

            Send.SendOrderDetails(clientSocket, OI);
        }

        internal static void UpdateOrderStatus(Socket clientSocket)
        {
            string orderID = Receive.ReceiveMessage(clientSocket);

            string orderStatus = Receive.ReceiveMessage(clientSocket);

            DAL.ExecCommand($"UPDATE `order` SET `status` = '{orderStatus}' WHERE `ID` = {orderID};");
        }

        internal static void GetCustomerOrder(Socket clientSocket)
        {
            string custID = Receive.ReceiveMessage(clientSocket);

            string sqlQuery = $"SELECT * FROM `order` WHERE CustomerID = {custID}";

            DataTable custOrders = DAL.ExecCommand(sqlQuery);

            List<OrderInfo> OIList = new List<OrderInfo>();

            Send.SendMessage(clientSocket, custOrders.Rows.Count.ToString());

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
                Send.SendOrderDetails(clientSocket, curOrder);
            }
        }
    }
}
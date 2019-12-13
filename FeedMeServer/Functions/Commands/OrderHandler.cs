using FeedMeNetworking;
using FeedMeNetworking.Models;
using FeedMeNetworking.Serialization;
using FeedMeServer.Functions.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeServer.Functions.Commands
{
    class OrderHandler
    {
        public static void CheckOrder(Socket Client)
        {
            OrderInfo orderInfo = Receive.ReceiveOrderInfo(Client);
            UserInfo userDetails = Receive.ReceiveUserInfo(Client);
            Send.SendMessage(Client, AddOrderToDB(orderInfo, userDetails).ToString());
        }

        private static int AddOrderToDB(OrderInfo orderInfo, UserInfo userDetails)
        {
            DAL.ExecCommand($"INSERT INTO `order` (CustomerID, VendorID) VALUES ({userDetails.UserID}, {orderInfo.VendorID})");
            DataTable IdDT = DAL.ExecCommand($"SELECT id FROM `order` WHERE `CustomerID` = {userDetails.UserID} ORDER BY id DESC LIMIT 1");
            int OrderID = Convert.ToInt32(IdDT.Rows[0][0]);

            foreach (ItemModel Item in orderInfo.Items)
            {
                string SQLQuery = ($"INSERT INTO `orderline` (OrderID, ItemID, Quantity) VALUES ({OrderID}, {Item.ItemID}, {Item.Quantity})");
                DAL.ExecCommand(SQLQuery);
            }

            if (DAL.ErrorCode == -1)
            {
                return 1;
            }

            return 0;

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
                OI.VendorID = Convert.ToInt32(Order[2]);
                OI.CustomerName = Order[4].ToString();
                Console.WriteLine(OI.CustomerName);
                OI.Items = new List<ItemModel>();
                int OrderID = Convert.ToInt32(Order[0]);

                DataTable orderInfo = DAL.ExecCommand($"SELECT * FROM `orderline` WHERE OrderID = {OrderID}");
                foreach (DataRow OrderItem in orderInfo.Rows)
                {
                    ItemModel ItemInfo = new ItemModel();
                    DataTable Item = DAL.ExecCommand($"SELECT * FROM items WHERE ItemID = {Convert.ToInt32(OrderItem[0])}");
                    Console.WriteLine($"SELECT * FROM items WHERE ItemID = {Convert.ToInt32(OrderItem[0])}");

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
    }
}

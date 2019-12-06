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
            AddOrderToDB(orderInfo, userDetails);
        }

        private static void AddOrderToDB(OrderInfo orderInfo, UserInfo userDetails)
        {
            DAL.ExecCommand($"INSERT INTO `order` (CustomerID, VendorID) VALUES ({userDetails.UserID}, {orderInfo.VendorID})");
            DataTable IdDT = DAL.ExecCommand($"SELECT id FROM `order` WHERE `CustomerID` = {userDetails.UserID} ORDER BY id DESC LIMIT 1");
            int OrderID = Convert.ToInt32(IdDT.Rows[0][0]);

            foreach (ItemModel Item in orderInfo.Items)
            {
                string SQLQuery = ($"INSERT INTO `orderline` (OrderID, ItemID, Quantity) VALUES ({OrderID}, {Item.ItemID}, {Item.Quantity})");
                DAL.ExecCommand(SQLQuery);
            }

        }

        internal static void CheckForOrders(Socket clientSocket)
        {
            string venID = Receive.ReceiveMessage(clientSocket);

            DataTable DT = DAL.ExecCommand($"SELECT * FROM `order` WHERE `VendorID` = {venID} AND status = 'processing';");

            int OrderID = Convert.ToInt32(DT.Rows[0][1]);

            DataTable ItemTable = DAL.ExecCommand($"SELECT * FROM `orderline` WHERE OrderID = {OrderID}");

            OrderInfo  OI = new OrderInfo();

            Send.SendOrderDetails(clientSocket, OI);
        }
    }
}

using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using System;
using System.Collections.Generic;
using System.Threading;

namespace FeedMeLogic.Server
{
    public class ConfirmOrder
    {
        private static void SendMainCommand(string command)
        {
            Send.SendToken(ServerConnection.ServerSock);

            Send.SendMessage(ServerConnection.ServerSock, "OrderHandling");

            Send.SendMessage(ServerConnection.ServerSock, command);
        }
        public static string SendOrder(OrderInfo orderInfo, UserInfo userInformation)
        {
            SendMainCommand("ConfirmOrder");

            Send.SendOrderDetails(ServerConnection.ServerSock, orderInfo);

            Send.SendUserInfo(ServerConnection.ServerSock, userInformation);

            return Receive.ReceiveMessage(ServerConnection.ServerSock);
        }

        public static List<OrderInfo> CheckForOrders(int vendorID, string status)
        {
            List<OrderInfo> OIList = new List<OrderInfo>();

            SendMainCommand("CheckForOrder");

            Send.SendMessage(ServerConnection.ServerSock, vendorID.ToString());

            Send.SendMessage(ServerConnection.ServerSock, status);

            int newOrderAmount = Convert.ToInt32(Receive.ReceiveMessage(ServerConnection.ServerSock));
            for (int i = 0; i < newOrderAmount; i++)
            {
                OIList.Add(Receive.ReceiveOrderInfo(ServerConnection.ServerSock));
            }
            return OIList;
        }

        public static OrderInfo GetSpecificOrder(string orderID)
        {
            SendMainCommand("GetSpecificOrder");

            Send.SendMessage(ServerConnection.ServerSock, orderID.ToString());

            OrderInfo CustOrder = Receive.ReceiveOrderInfo(ServerConnection.ServerSock);

            return CustOrder;
        }

        public static void UpdateOrderStatus(string orderID, string orderStatus)
        {
            SendMainCommand("UpdateOrderStatus");

            Send.SendMessage(ServerConnection.ServerSock, orderID.ToString());

            Send.SendMessage(ServerConnection.ServerSock, orderStatus);
        }

        public static void UpdateRefundStatus(string orderID, string refundStatus)
        {
            SendMainCommand("UpdateRefundStatus");

            Send.SendMessage(ServerConnection.ServerSock, orderID.ToString());

            Send.SendMessage(ServerConnection.ServerSock, refundStatus);
        }

        public static List<OrderInfo> GetCustomerOrders(string customerID)
        {
            List<OrderInfo> OIList = new List<OrderInfo>();

            SendMainCommand("GetCustomerOrder");

            Send.SendMessage(ServerConnection.ServerSock, customerID);

            int newOrderAmount = Convert.ToInt32(Receive.ReceiveMessage(ServerConnection.ServerSock));

            for (int i = 0; i < newOrderAmount; i++)
            {
                OIList.Add(Receive.ReceiveOrderInfo(ServerConnection.ServerSock));
            }

            return OIList;
        }
        
        public static List<OrderInfo> GetRefunds()
        {
            List<OrderInfo> OIList = new List<OrderInfo>();

            SendMainCommand("GetRefunds");

            int newOrderAmount = Convert.ToInt32(Receive.ReceiveMessage(ServerConnection.ServerSock));

            for (int i = 0; i < newOrderAmount; i++)
            {
                OIList.Add(Receive.ReceiveOrderInfo(ServerConnection.ServerSock));
            }

            return OIList;
        }
    }
}
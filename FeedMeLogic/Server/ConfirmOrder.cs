using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using System;
using System.Collections.Generic;

namespace FeedMeLogic.Server
{
    public class ConfirmOrder
    {
        public static string SendOrder(OrderInfo orderInfo, UserInfo userInformation)
        {
            Send.SendMessage(ServerConnection.ServerSock, "ConfirmOrder");

            Send.SendOrderDetails(ServerConnection.ServerSock, orderInfo);

            Send.SendUserInfo(ServerConnection.ServerSock, userInformation);

            return Receive.ReceiveMessage(ServerConnection.ServerSock);
        }

        public static List<OrderInfo> CheckForOrders(int vendorID)
        {
            List<OrderInfo> OIList = new List<OrderInfo>();

            Send.SendMessage(ServerConnection.ServerSock, "CheckForOrder");

            Send.SendMessage(ServerConnection.ServerSock, vendorID.ToString());

            int newOrderAmount = Convert.ToInt32(Receive.ReceiveMessage(ServerConnection.ServerSock));
            for (int i = 0; i < newOrderAmount; i++)
            {
                OIList.Add(Receive.ReceiveOrderInfo(ServerConnection.ServerSock));
            }
            return OIList;
        }

        public static OrderInfo GetSpecificOrder(string orderID)
        {
            Send.SendMessage(ServerConnection.ServerSock, "GetSpecificOrder");

            Send.SendMessage(ServerConnection.ServerSock, orderID.ToString());

            OrderInfo CustOrder = Receive.ReceiveOrderInfo(ServerConnection.ServerSock);

            return CustOrder;
        }

        public static void UpdateOrderStatus(string orderID, string orderStatus)
        {
            Send.SendMessage(ServerConnection.ServerSock, "UpdateOrderStatus");

            Send.SendMessage(ServerConnection.ServerSock, orderID.ToString());

            Send.SendMessage(ServerConnection.ServerSock, orderStatus);
        }
    }
}
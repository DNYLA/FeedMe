using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using System;
using System.Collections.Generic;
using System.Threading;

namespace FeedMeLogic.Server
{
    public class ConfirmOrder
    {
        /// <summary>
        /// Sends the Main OrderHandling Command to the server
        /// </summary>
        /// <param name="command">Extra Command which will be sent to the server along with the command</param>
        private static void SendMainCommand(string command)
        {
            Send.SendToken(ServerConnection.ServerSock);

            Send.SendMessage(ServerConnection.ServerSock, "OrderHandling");

            Send.SendMessage(ServerConnection.ServerSock, command);
        }

        /// <summary>
        /// Sends a New Order to the Server
        /// </summary>
        /// <param name="orderInfo"></param>
        /// <param name="userInformation"></param>
        /// <returns></returns>
        public static string SendOrder(OrderInfo orderInfo, UserInfo userInformation)
        {
            SendMainCommand("ConfirmOrder");

            Send.SendOrderDetails(ServerConnection.ServerSock, orderInfo);

            Send.SendUserInfo(ServerConnection.ServerSock, userInformation);

            return Receive.ReceiveMessage(ServerConnection.ServerSock);
        }

        /// <summary>
        /// Checks for orders on the database
        /// </summary>
        /// <param name="vendorID"></param>
        /// <param name="status"></param>
        /// <returns></returns>
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

        /// <summary>
        /// requests a Specific order from an orderID
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public static OrderInfo GetSpecificOrder(string orderID)
        {
            SendMainCommand("GetSpecificOrder");

            Send.SendMessage(ServerConnection.ServerSock, orderID.ToString());

            OrderInfo CustOrder = Receive.ReceiveOrderInfo(ServerConnection.ServerSock);

            return CustOrder;
        }

        /// <summary>
        /// Updates an order Status from an OrderID
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="orderStatus"></param>
        public static void UpdateOrderStatus(string orderID, string orderStatus)
        {
            SendMainCommand("UpdateOrderStatus");

            Send.SendMessage(ServerConnection.ServerSock, orderID.ToString());

            Send.SendMessage(ServerConnection.ServerSock, orderStatus);
        }

        /// <summary>
        /// Updates Refund Status based on an OrderID
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="refundStatus"></param>
        public static void UpdateRefundStatus(string orderID, string refundStatus)
        {
            SendMainCommand("UpdateRefundStatus");

            Send.SendMessage(ServerConnection.ServerSock, orderID.ToString());

            Send.SendMessage(ServerConnection.ServerSock, refundStatus);
        }

        /// <summary>
        /// Gets all orders from a specific customer
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns>A List of OrderInfo</returns>
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
        
        /// <summary>
        /// Gets a List of Refunds
        /// </summary>
        /// <returns></returns>
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
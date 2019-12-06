using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static OrderInfo CheckForOrders(int vendorID)
        {

            Send.SendMessage(ServerConnection.ServerSock, "CheckForOrder");

            Send.SendMessage(ServerConnection.ServerSock, vendorID.ToString());

            return Receive.ReceiveOrderInfo(ServerConnection.ServerSock);
        }
    }
}

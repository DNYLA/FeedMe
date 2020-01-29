using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeLogic.Server
{
    public class UserHandler
    {
        public static UserInfo GetUserInfo(int userID)
        {
            Send.SendMessage(ServerConnection.ServerSock, "GetUserInfo");
            Send.SendMessage(ServerConnection.ServerSock, userID.ToString());

            return Receive.ReceiveUserInfo(ServerConnection.ServerSock);
        }
        
        public static void UpdateUserInfo(UserInfo UI)
        {
            Send.SendMessage(ServerConnection.ServerSock, "UpdateUserInfo");
            Send.SendUserInfo(ServerConnection.ServerSock, UI);
        }
    }
}

using FeedMeSerialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FeedMeNetworking;

namespace FeedMeClient.Functions.Server
{
    class AuthenticationHandler
    {
        public static UserInfo AuthenticateLogin(string username, string password)
        {
            Send.SendMessage(ServerConnection.ServerSock, "Login");

            Send.SendMessage(ServerConnection.ServerSock, username);

            Send.SendMessage(ServerConnection.ServerSock, password);

            return Receive.ReceiveUserInfo(ServerConnection.ServerSock);
        }

        public static int RegisterUser(UserInfo UserInformation)
        {
            Send.SendMessage(ServerConnection.ServerSock, "Register");

            //ServerConnection.SendMessage();

            return 3;
        }
    }
}

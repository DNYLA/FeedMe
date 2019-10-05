using FeedMeSerialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FeedMeClient.Functions.Server
{
    class AuthenticationHandler
    {
        public static UserInfo AuthenticateLogin(string username, string password)
        {
            ServerConnection.SendMessage("Login");

            ServerConnection.SendMessage(username);

            ServerConnection.SendMessage(password);

            return ServerConnection.ReceiveUserInfo();
        }

        public static int RegisterUser()
        {

        }
    }
}

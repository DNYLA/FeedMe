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

            string salt = Receive.ReceiveMessage(ServerConnection.ServerSock);

            //If Salt Returns -1 then Username received is invalid
            if (salt == "-1")
            {
                UserInfo UserInformation = new UserInfo();

                UserInformation.UserID = -1;
                return UserInformation;
            }

            Send.SendMessage(ServerConnection.ServerSock, Data.HashPass.ConfirmHash(password, salt));

            return Receive.ReceiveUserInfo(ServerConnection.ServerSock);
        }

        public static int RegisterUser(UserInfo UserInformation)
        {
            Send.SendMessage(ServerConnection.ServerSock, "Register");

            Send.SendUserInfo(ServerConnection.ServerSock, UserInformation);

            return Convert.ToInt32(Receive.ReceiveMessage(ServerConnection.ServerSock));
        }
    }
}

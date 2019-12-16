using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using System;

namespace FeedMeLogic.Server
{
    public class AuthenticationHandler
    {
        public static object AuthenticateLogin(string username, string password, int LoginType)
        {
            Send.SendMessage(ServerConnection.ServerSock, "Login");

            Send.SendMessage(ServerConnection.ServerSock, LoginType.ToString());

            if (LoginType == 0)
            {
                return CustomerLogin(username, password);
            }
            else if (LoginType == 1)
            {
                return VendorLogin(username, password);
            }

            Send.SendMessage(ServerConnection.ServerSock, username);

            return Receive.ReceiveUserInfo(ServerConnection.ServerSock);
        }

        public static string GetSalt(string password)
        {
            string salt = Receive.ReceiveMessage(ServerConnection.ServerSock);
            //If Salt Returns -1 then Username received is invalid
            if (salt == "-1")
            {
                return "-1";
            }

            Send.SendMessage(ServerConnection.ServerSock, FeedMeLogic.Data.HashPass.ConfirmHash(password, salt));

            return salt;
        }

        /// <summary>
        /// Login Function that Returns an Object which can then be casted/converted into UserInfo
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static object CustomerLogin(string username, string password)
        {
            //Send.SendMessage(ServerConnection.ServerSock, "Login");

            Send.SendMessage(ServerConnection.ServerSock, username);

            string salt = GetSalt(password);

            Send.SendMessage(ServerConnection.ServerSock, FeedMeLogic.Data.HashPass.ConfirmHash(password, salt));

            return Receive.ReceiveUserInfo(ServerConnection.ServerSock);
        }

        /// <summary>
        /// Login Function that Returns an Object which can then be casted/converted into VendorInfo
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static object VendorLogin(string username, string password)
        {
            Send.SendMessage(ServerConnection.ServerSock, username);

            string salt = GetSalt(password);

            //If Salt Returns -1 then Username received is invalid
            if (salt == "-1")
            {
                VendorInfo VendorInformation = new VendorInfo
                {
                    VendorID = -1
                };
                return VendorInformation;
            }

            Send.SendMessage(ServerConnection.ServerSock, FeedMeLogic.Data.HashPass.ConfirmHash(password, salt));

            return Receive.ReceiveVendorInfo(ServerConnection.ServerSock);
        }

        public static int RegisterUser(UserInfo UserInformation)
        {
            Send.SendMessage(ServerConnection.ServerSock, "Register");

            Send.SendUserInfo(ServerConnection.ServerSock, UserInformation);

            return Convert.ToInt32(Receive.ReceiveMessage(ServerConnection.ServerSock));
        }
    }

    public enum ObjectType
    {
        VendorObject, UserObject
    }
}

using FeedMeNetworking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeLogic.Server
{
    public class ReviewHandler
    {
        private static void SendMainCommand(string command)
        {
            Send.SendToken(ServerConnection.ServerSock);

            Send.SendMessage(ServerConnection.ServerSock, "ReviewHandler");

            Send.SendMessage(ServerConnection.ServerSock, command);
        }

        public static void CreateReview(string orderID, string review, string rating)
        {
            SendMainCommand("CreateReview");

            Send.SendMessage(ServerConnection.ServerSock, orderID);

            Send.SendMessage(ServerConnection.ServerSock, review);

            Send.SendMessage(ServerConnection.ServerSock, rating);
        }
    }
}

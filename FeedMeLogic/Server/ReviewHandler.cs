using FeedMeNetworking;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
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

        public static DataTable GetReviews(string vendorID)
        {
            SendMainCommand("GetAllReviews");

            Send.SendMessage(ServerConnection.ServerSock, vendorID);

            return Receive.ReceiveDataTable(ServerConnection.ServerSock);
        }

        public static decimal CalculateRating(string vendorID)
        {
            DataTable dt = GetReviews(vendorID);
            int total = 0;

            foreach (DataRow review in dt.Rows)
            {
                total += Convert.ToInt32(review[4]);
            }

            return total / dt.Rows.Count;


        }
    }
}

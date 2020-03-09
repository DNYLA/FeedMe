using FeedMeNetworking;
using FeedMeServer.Functions.Data;
using FeedMeServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeServer.Functions.Commands
{
    internal class ReviewHandler
    {
        private Client clientInf;

        public void HandleReviews(ref Client clientM)
        {
            clientInf = clientM;

            Socket client = clientM.ClientSocket;

            string specificCommand = Receive.ReceiveMessage(client); //Get Command From Client

            //Calls Method based on command
            switch (specificCommand)
            {
                case "CreateReview":
                    CreateReview();
                    break;
                case "GetAllReviews":
                    GetReviews();
                    break;
            }
        }

        private static void GetReviews()
        {
            throw new NotImplementedException();
        }

        private void CreateReview()
        {
            int orderID = Convert.ToInt32(Receive.ReceiveMessage(clientInf.ClientSocket));
            string message = Receive.ReceiveMessage(clientInf.ClientSocket);
            int rating = Convert.ToInt32(Receive.ReceiveMessage(clientInf.ClientSocket));


            string sqlQ = $"UPDATE `order` SET `review` = '{message}', `rating` = {rating} WHERE `ID` = {orderID};";
            DAL.ExecCommand(sqlQ);
        }
    }
}

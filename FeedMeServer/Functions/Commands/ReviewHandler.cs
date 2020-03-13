using FeedMeNetworking;
using FeedMeServer.Functions.Data;
using FeedMeServer.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        public void GetReviews()
        {
            string vendorID = Receive.ReceiveMessage(clientInf.ClientSocket);
            string qry = $"SELECT STATUS, refunded, DatePurchased, review, rating, firstname, lastname  FROM `order`, `users` WHERE vendorID = {vendorID}  AND review IS NOT NULL AND `order`.CustomerID = `users`.UserID;";
            DataTable dt = DAL.ExecCommand(qry);

            Send.SendDataTable(clientInf.ClientSocket, dt);
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

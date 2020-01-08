using FeedMeNetworking;
using FeedMeServer.Functions.Data;
using System;
using System.Net.Sockets;

namespace FeedMeServer.Functions.Commands.Vendor
{
    internal class StoreInfo
    {
        public static void GetStoreInfo(Socket Client)
        {
            string vendorID = Receive.ReceiveMessage(Client);

            String SQLQuery = ($"SELECT Name, Description, Address, Email, Postcode, PhoneNo, Rating From vendors WHERE VendorID = {vendorID};");

            Send.SendDataTable(Client, DAL.ExecCommand(SQLQuery));
        }
    }
}
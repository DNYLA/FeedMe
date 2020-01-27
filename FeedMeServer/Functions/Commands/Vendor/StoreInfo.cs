using FeedMeNetworking;
using FeedMeNetworking.Serialization;
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

        internal static void UpdateStoreInfo(Socket clientSocket)
        {
            VendorInfo venData = Receive.ReceiveVendorInfo(clientSocket);
            string updateQuery = $@"UPDATE vendors SET `Name` = '{venData.Name}', `Description` = '{venData.Description}', `Address` = '{venData.Description}', `Email` = '{venData.Description}', `Postcode` = '{venData.Postcode}', `PhoneNo` = '{venData.PhoneNo}'
                                    WHERE vendorID = {venData.VendorID};";
            DAL.ExecCommand(updateQuery);
        }
    }
}
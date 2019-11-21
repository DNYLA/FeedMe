using FeedMeNetworking;
using FeedMeServer.Functions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeServer.Functions.Commands.Vendor
{
    class StoreInfo
    {
        public static void GetStoreInfo(Socket Client)
        {
            string vendorID = Receive.ReceiveMessage(Client);

            String SQLQuery = ($"SELECT Name, Description, Address, Email, Postcode, PhoneNo, Rating From vendors WHERE VendorID = {vendorID};");

            Send.SendDataTable(Client, DAL.ExecCommand(SQLQuery));
        }
    }
}

using FeedMeNetworking;
using FeedMeServer.Functions.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;

namespace FeedMeServer.Functions.Commands.Vendor
{
    internal class Categories
    {
        private static void CategoryHandler(Socket Client)
        {
            ServerMain.ServerLogger("Requested Category List", "Vendor");

            //Receive Client Information
            string vendorID = Receive.ReceiveMessage(Client);

            DataTable DT = DAL.ExecCommand($@"SELECT category FROM items
                                            WHERE VendorID = {vendorID}
                                            GROUP BY category
                                            ORDER BY category ASC;");

            List<String> CategoryList = new List<String>();
            foreach (DataRow CRow in DT.Rows)
            {
                CategoryList.Add(CRow[0].ToString());
            }

            //CategoryList.Count
        }
    }
}
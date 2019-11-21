using FeedMeNetworking;
using FeedMeServer.Functions.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeServer.Functions.Commands.Vendor
{
    class StoreMenuHandler
    {
        private static Socket Client;
        public static void MenuHandler(Socket client)
        {
            Client = client;

            string vendorID = Receive.ReceiveMessage(client);

            string specificCommand = Receive.ReceiveMessage(client);

            switch (specificCommand)
            {
                case "GetCategories":
                    GetCategories(vendorID);
                    break;
                case "GetItemList":
                    GetItems(vendorID);
                    break;
                case "AddCat":
                    AddCategory(vendorID);
                    break;
                case "EditCat":
                    EditCategory(vendorID);
                    break;
                case "RmoveCat":
                    RemoveCategory(vendorID);
                    break;
                case "AddItem":
                    AddItem(vendorID);
                    break;
                case "EditItem":
                    EditItem(vendorID);
                    break;
                case "RemoveItem":
                    RemoveItem(vendorID);
                    break;
            }
        }

        private static void GetCategories(string vendorID)
        {
            string SQLQuery = ($"SELECT* FROM items WHERE VendorID = {vendorID}");
            DataTable ItemInfo = Data.DAL.ExecCommand(SQLQuery);
            Send.SendDataTable(Client, ItemInfo);
        }

        private static void GetItems(string vendorID)
        {
            string category = Receive.ReceiveMessage(Client);
            string SQLQuery = ($"SELECT* FROM items WHERE VendorID = {vendorID} AND Category = '{category}'");
            DataTable ItemInfo = Data.DAL.ExecCommand(SQLQuery);
            Send.SendDataTable(Client, ItemInfo);
        }

        private static void AddCategory(string vendorID)
        {
            string CategoryName = Receive.ReceiveMessage(Client);

        }
        private static void EditCategory(string vendorID)
        {
            string curCatName = Receive.ReceiveMessage(Client);
            string newCatName = Receive.ReceiveMessage(Client);
            string query = ($"UPDATE items SET Category =  '{newCatName}' WHERE Category = '{curCatName}' AND vendorID = {vendorID};");
            DAL.ExecCommand(query);
            SendSuccessMessage();
        }

        private static void RemoveCategory(string vendorID)
        {
            string catName = Receive.ReceiveMessage(Client);
            string query = ($"DELETE FROM items WHERE Category = '{catName}' AND vendorID = '{vendorID}';");
            DAL.ExecCommand(query);
            SendSuccessMessage();
        }

        private static void AddItem(string vendorID)
        {
            string item = Receive.ReceiveMessage(Client);
            string cat = Receive.ReceiveMessage(Client);
            string desc = Receive.ReceiveMessage(Client);
            decimal price = Convert.ToDecimal(Receive.ReceiveMessage(Client));
            string query = ($"INSERT INTO items (vendorID, ItemName, Category, Description, Price) VALUES ({vendorID}, '{item}', '{cat}', '{desc}', {price});");
            DAL.ExecCommand(query);
            SendSuccessMessage();
        }

        private static void EditItem(string vendorID)
        {
            string oldItemName = Receive.ReceiveMessage(Client);
            string item = Receive.ReceiveMessage(Client);
            string cat = Receive.ReceiveMessage(Client);
            string desc = Receive.ReceiveMessage(Client);
            decimal price = Convert.ToDecimal(Receive.ReceiveMessage(Client));
            string query = ($"UPDATE items SET ItemName = '{item}', Category = '{cat}', Description = '{desc}', Price = {price} WHERE vendorID = {vendorID} AND ItemName = '{oldItemName}';");
            DAL.ExecCommand(query);
            SendSuccessMessage();
        }

        private static void RemoveItem(string vendorID)
        {
            string cat = Receive.ReceiveMessage(Client);
            string itemName = Receive.ReceiveMessage(Client);
            
            string query = ($"DELETE FROM items WHERE Category = '{cat}' AND vendorID = '{vendorID}' AND ItemName = '{itemName}';");
            DAL.ExecCommand(query);
            SendSuccessMessage();
        }

        private static void SendSuccessMessage()
        {
            Send.SendMessage(Client, "Success");
        }
    }
}

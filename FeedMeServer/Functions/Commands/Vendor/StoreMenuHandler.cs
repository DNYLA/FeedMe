using FeedMeNetworking;
using FeedMeServer.Functions.Data;
using System;
using System.Data;
using System.Net.Sockets;

namespace FeedMeServer.Functions.Commands.Vendor
{
    internal class StoreMenuHandler
    {
        private static Socket Client; //Can only be acessed in this class

        /// <summary>
        /// Receives Specific Request and calls the correct method based on the request
        /// </summary>
        /// <param name="client"></param>
        public static void MenuHandler(Socket client)
        {
            Client = client;

            string vendorID = Receive.ReceiveMessage(client);

            string specificCommand = Receive.ReceiveMessage(client); //Command from the Client

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

        /// <summary>
        /// Gets Category From a specific vendor in the database
        /// </summary>
        /// <param name="vendorID">Vendor which requested the data</param>
        private static void GetCategories(string vendorID)
        {
            string SQLQuery = ($"SELECT* FROM items WHERE VendorID = {vendorID}");
            DataTable ItemInfo = Data.DAL.ExecCommand(SQLQuery);
            Send.SendDataTable(Client, ItemInfo);
        }

        /// <summary>
        /// Gets A specific Item from a vendor in the database
        /// </summary>
        /// <param name="vendorID">Vendor which requested the data</param>
        private static void GetItems(string vendorID)
        {
            string category = Receive.ReceiveMessage(Client);
            string SQLQuery = ($"SELECT* FROM items WHERE VendorID = {vendorID} AND Category = '{category}'");
            DataTable ItemInfo = Data.DAL.ExecCommand(SQLQuery);
            Send.SendDataTable(Client, ItemInfo);
        }

        /// <summary>
        /// Adds a Category to the database
        /// </summary>
        /// <param name="vendorID">Vendor which requested the data</param>
        private static void AddCategory(string vendorID)
        {
            string CategoryName = Receive.ReceiveMessage(Client);
        }

        /// <summary>
        /// Edits a Category which has been requested from the vendor
        /// </summary>
        /// <param name="vendorID">Vendor which requested the data</param>
        private static void EditCategory(string vendorID)
        {
            string curCatName = Receive.ReceiveMessage(Client);
            string newCatName = Receive.ReceiveMessage(Client);
            string query = ($"UPDATE items SET Category =  '{newCatName}' WHERE Category = '{curCatName}' AND vendorID = {vendorID};");
            DAL.ExecCommand(query);
            SendSuccessMessage();
        }

        /// <summary>
        /// Removes a category from the database
        /// </summary>
        /// <param name="vendorID">Vendor which requested the data</param>
        private static void RemoveCategory(string vendorID)
        {
            string catName = Receive.ReceiveMessage(Client);
            string query = ($"DELETE FROM items WHERE Category = '{catName}' AND vendorID = '{vendorID}';");
            DAL.ExecCommand(query);
            SendSuccessMessage();
        }

        /// <summary>
        /// Adds an item to the database 
        /// </summary>
        /// <param name="vendorID">Vendor which requested the data</param>
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

        /// <summary>
        /// Edits an item in the database which is linked to the vendor
        /// </summary>
        /// <param name="vendorID">Vendor which requested the data</param>
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

        /// <summary>
        /// Removes an item from the database which is linked with the vendor
        /// </summary>
        /// <param name="vendorID">Vendor which requested the data</param>
        private static void RemoveItem(string vendorID)
        {
            string cat = Receive.ReceiveMessage(Client);
            string itemName = Receive.ReceiveMessage(Client);

            string query = ($"DELETE FROM items WHERE Category = '{cat}' AND vendorID = '{vendorID}' AND ItemName = '{itemName}';");
            DAL.ExecCommand(query);
            SendSuccessMessage();
        }

        /// <summary>
        /// Sends Success Message Indicating everything has been processed
        /// </summary>
        private static void SendSuccessMessage()
        {
            Send.SendMessage(Client, "Success");
        }
    }
}
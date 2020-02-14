using FeedMeLogic.Server;
using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using System.Data;
using System.Threading;

namespace FeedMeLogic.Vendor
{
    public class StoreMenuInfo
    {
        /// <summary>
        /// Sends Main Request To Server along with sub command
        /// </summary>
        /// <param name="vendorID">VendorID which requested the command</param>
        /// <param name="command">Sub Command</param>
        private static void SendRequestCommand(string vendorID, string command)
        {
            Send.SendToken(ServerConnection.ServerSock);
            Thread.Sleep(100);
            Send.SendMessage(ServerConnection.ServerSock, "StoreMenuInfo");
            Thread.Sleep(100);
            Send.SendMessage(ServerConnection.ServerSock, vendorID);
            Thread.Sleep(100);
            Send.SendMessage(ServerConnection.ServerSock, command);
            Thread.Sleep(100);
        }

        /// <summary>
        /// Edits A Category
        /// </summary>
        /// <param name="vendorID">VendorID which requested the edit</param>
        /// <param name="oldName">Current Name of the category</param>
        /// <param name="newName">New Category Name</param>
        /// <returns>Success Message</returns>
        public static string EditCategory(string vendorID, string oldName, string newName)
        {
            SendRequestCommand(vendorID, "EditCat");
            Thread.Sleep(100);
            Send.SendMessage(ServerConnection.ServerSock, oldName);
            Thread.Sleep(100);
            Send.SendMessage(ServerConnection.ServerSock, newName);
            return Receive.ReceiveMessage(ServerConnection.ServerSock);
        }

        /// <summary>
        /// Removes A category from the database
        /// </summary>
        /// <param name="vendorID">VendorID Which requested the removal</param>
        /// <param name="catName">Category Name To be deleted</param>
        /// <returns>Success message</returns>
        public static string RemoveCategory(string vendorID, string catName)
        {
            SendRequestCommand(vendorID, "RemoveCat");
            Send.SendMessage(ServerConnection.ServerSock, catName);
            return Receive.ReceiveMessage(ServerConnection.ServerSock);
        }

        /// <summary>
        /// Adds an Item To the database
        /// </summary>
        /// <param name="vendorID">VendorID which requested to add an item</param>
        /// <param name="oldItemName">N/A (Does Nothing)</param>
        /// <param name="item">Item Name</param>
        /// <param name="catName">Category the Item is in</param>
        /// <param name="desc">Description of item</param>
        /// <param name="price">Price of new item</param>
        /// <returns>Success Message</returns>
        public static string AddItem(string vendorID, string oldItemName, string item, string catName, string desc, decimal price)
        {
            SendRequestCommand(vendorID, "AddItem");

            Send.SendMessage(ServerConnection.ServerSock, oldItemName);
            Send.SendMessage(ServerConnection.ServerSock, item);
            Send.SendMessage(ServerConnection.ServerSock, catName);
            Send.SendMessage(ServerConnection.ServerSock, desc);
            Send.SendMessage(ServerConnection.ServerSock, price.ToString());

            return Receive.ReceiveMessage(ServerConnection.ServerSock);
        }

        /// <summary>
        /// Sends Removes Item Command To Server
        /// </summary>
        /// <param name="vendorID">VendorID which requested the removal</param>
        /// <param name="catName">Category The Item is inside</param>
        /// <param name="itemName">Item Name of the item which needs to be removed</param>
        /// <returns>Success Message</returns>
        public static string RemoveItem(string vendorID, string catName, string itemName)
        {
            SendRequestCommand(vendorID, "RemoveItem");

            Send.SendMessage(ServerConnection.ServerSock, catName);
            Send.SendMessage(ServerConnection.ServerSock, itemName);

            return Receive.ReceiveMessage(ServerConnection.ServerSock);
        }

        /// <summary>
        /// Gets all the Categories on the menu for a vendor
        /// </summary>
        /// <param name="vendorID">The VendorID which the menu will be from</param>
        /// <returns>DataTable of Item Information.</returns>
        public static DataTable GetMenuInfo(string vendorID)
        {
            SendRequestCommand(vendorID, "GetCategories");

            return Receive.ReceiveDataTable(ServerConnection.ServerSock);
        }

        /// <summary>
        /// Gets all the items from a cetgory for a vendor
        /// </summary>
        /// <param name="vendorID">Vendor Which requested the Items</param>
        /// <param name="CatName">Category to check from</param>
        /// <returns>Success Message</returns>
        public static DataTable GetItemList(string vendorID, string CatName)
        {
            SendRequestCommand(vendorID, "GetItemList");

            Send.SendMessage(ServerConnection.ServerSock, CatName);

            return Receive.ReceiveDataTable(ServerConnection.ServerSock);
        }

        /// <summary>
        /// Gets all information about a store
        /// </summary>
        /// <param name="vendorID">VendorID for the store</param>
        /// <returns>Success Message</returns>
        public static DataTable GetStoreInfo(string vendorID)
        {
            Send.SendToken(ServerConnection.ServerSock);

            Send.SendMessage(ServerConnection.ServerSock, "StoreInfo");
            Send.SendMessage(ServerConnection.ServerSock, vendorID);

            return Receive.ReceiveDataTable(ServerConnection.ServerSock);
        }

        /// <summary>
        /// Updates Store Information
        /// </summary>
        /// <param name="VI">The New Store Information</param>
        public void UpdateStoreInfo(VendorInfo VI)
        {
            Send.SendToken(ServerConnection.ServerSock);

            Send.SendMessage(ServerConnection.ServerSock, "UpdateStoreInfo");
            Send.SendVendorInfo(ServerConnection.ServerSock, VI);
        }
    }
}
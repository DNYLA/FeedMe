using FeedMeLogic.Server;
using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using System.Data;
using System.Threading;

namespace FeedMeLogic.Vendor
{
    public class StoreMenuInfo
    {
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

        public static string EditCategory(string vendorID, string oldName, string newName)
        {
            SendRequestCommand(vendorID, "EditCat");
            Thread.Sleep(100);
            Send.SendMessage(ServerConnection.ServerSock, oldName);
            Thread.Sleep(100);
            Send.SendMessage(ServerConnection.ServerSock, newName);
            return Receive.ReceiveMessage(ServerConnection.ServerSock);
        }

        public static string RemoveCategory(string vendorID, string catName)
        {
            SendRequestCommand(vendorID, "RemoveCat");
            Send.SendMessage(ServerConnection.ServerSock, catName);
            return Receive.ReceiveMessage(ServerConnection.ServerSock);
        }

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

        public static string RemoveItem(string vendorID, string catName, string itemName)
        {
            SendRequestCommand(vendorID, "RemoveItem");

            Send.SendMessage(ServerConnection.ServerSock, catName);
            Send.SendMessage(ServerConnection.ServerSock, itemName);

            return Receive.ReceiveMessage(ServerConnection.ServerSock);
        }

        public static DataTable GetMenuInfo(string vendorID)
        {
            SendRequestCommand(vendorID, "GetCategories");

            return Receive.ReceiveDataTable(ServerConnection.ServerSock);
        }

        public static DataTable GetItemList(string vendorID, string CatName)
        {
            SendRequestCommand(vendorID, "GetItemList");

            Send.SendMessage(ServerConnection.ServerSock, CatName);

            return Receive.ReceiveDataTable(ServerConnection.ServerSock);
        }

        public static DataTable GetStoreInfo(string vendorID)
        {
            Send.SendToken(ServerConnection.ServerSock);

            Send.SendMessage(ServerConnection.ServerSock, "StoreInfo");
            Send.SendMessage(ServerConnection.ServerSock, vendorID);

            return Receive.ReceiveDataTable(ServerConnection.ServerSock);
        }

        public void UpdateStoreInfo(VendorInfo VI)
        {
            Send.SendToken(ServerConnection.ServerSock);

            Send.SendMessage(ServerConnection.ServerSock, "UpdateStoreInfo");
            Send.SendVendorInfo(ServerConnection.ServerSock, VI);
        }
    }
}
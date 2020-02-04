using FeedMeNetworking.Serialization;
using System.Data;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace FeedMeNetworking
{
    public class Send
    {
        /*
         * ADD Function to decrypt BYTES.
         */

        public static string sToken = "";
        public static void SendDataTable(Socket Sock, DataTable dataTable)
        {
            SendData(Sock, ProtoBufSerialization.DataSerialization(dataTable));
        }

        /// <summary>
        /// Encodes a String message and sends it to the given socket
        /// </summary>
        /// <param name="Sock">Socket Which is sending the message</param>
        /// <param name="message">The Message to Encode and Send</param>
        public static void SendMessage(Socket Sock, string message)
        {
            //If Data is sent too quickly the server might read seperate messages as one string sometimes
            Thread.Sleep(100); //Small Sleep to prevent multiple messages stacking into one

            SendData(Sock, Encoding.UTF8.GetBytes(message));
        }

        public static void SendOrderDetails(Socket Sock, OrderInfo OrderInformation)
        {
            SendData(Sock, ProtoBufSerialization.ObjectSerialization(OrderInformation));
        }

        /// <summary>
        /// Serializes UserInfo Object and Uses SendData To Send it over the network
        /// </summary>
        /// <param name="UserInformation">Object That Needs to be Serialized</param>
        public static void SendUserInfo(Socket Sock, UserInfo UserInformation)
        {
            SendData(Sock, ProtoBufSerialization.ObjectSerialization(UserInformation));
        }

        public static void SendVendorInfo(Socket Sock, VendorInfo BussinessInfo)
        {
            SendData(Sock, ProtoBufSerialization.ObjectSerialization(BussinessInfo));
        }

        /// <summary>
        /// Simple Function which streams data over a network
        /// </summary>
        /// <param name="Sock">Socket of were data is going to be send to (This Could be A Client Or the Server)</param>
        /// <param name="data"> Byte Array of Data that will be send</param>
        private static void SendData(Socket Sock, byte[] data)
        {
            Send.SendMessage(Sock, sToken);
            Sock.Send(data, 0, data.Length, SocketFlags.None);

            //If Data is sent too quickly the server might read seperate messages as one string sometimes
            Thread.Sleep(100); //Small Sleep to prevent multiple messages stacking into one
        }

        
    }
}
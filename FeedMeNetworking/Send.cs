using FeedMeSerialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FeedMeNetworking
{
    public class Send
    {
        /*
         * ADD Function to decrypt BYTES.
         */


        /// <summary>
        /// Simple Function which streams data over a network
        /// </summary>
        /// <param name="Sock">Socket of were data is going to be send to (This Could be A Client Or the Server)</param>
        /// <param name="data"> Byte Array of Data that will be send</param>
        private static void SendData(Socket Sock, byte[] data)
        {
            Sock.Send(data, 0, data.Length, SocketFlags.None);

            //If Data is sent too quickly the server might read seperate messages as one string sometimes
            Thread.Sleep(100); //Small Sleep to prevent multiple messages stacking into one
        }


        /// <summary>
        /// Simple Function which executes a single command. Makes it quicker than writing everything out each time & if i ever decide to change the 
        /// Encoding Type from UTF8 to something different like UTF16 then i only have to change this function
        /// </summary>
        /// <param name="message">The String That Needs to be Serialized</param>
        public static void SendMessage(Socket Sock, string message)
        {
            //If Data is sent too quickly the server might read seperate messages as one string sometimes
            Thread.Sleep(100); //Small Sleep to prevent multiple messages stacking into one

            SendData(Sock, Encoding.UTF8.GetBytes(message));   
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
    }
}

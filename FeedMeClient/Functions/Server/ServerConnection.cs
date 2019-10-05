using FeedMeSerialization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedMeClient.Functions.Server
{
    class ServerConnection
    {
        static int PORT_NO = 4030;
        static string IP_ADDRESS = "127.0.0.1";
        static Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static string GlobalCommandToSend = "";

        public static void InitiailizeConnection()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IP_ADDRESS), PORT_NO);
            clientSocket.Connect(endPoint);
        }

        public static void CloseConnection()
        {
            clientSocket.Close(1000); //Waits 1 second to send any data
        }

        /// <summary>
        /// Simple Function which executes a single command. Makes it quicker than writing everything out each time & if i ever decide to change the 
        /// Encoding Type from UTF8 to something different like UTF16 then i only have to change this function
        /// </summary>
        /// <param name="message"></param>
        public static void SendMessage(string message)
        {
            clientSocket.Send(Encoding.UTF8.GetBytes(message), 0, message.Length, SocketFlags.None);

            //If Data is sent too quickly the server might read seperate messages as one string sometimes
            Thread.Sleep(100); //Small Sleep to prevent multiple messages stacking into one
        }

        /// <summary>
        /// Receives Data And Returns it as a byte
        /// </summary>
        /// <returns>Message From Server as a Byte</returns>
        private static byte[] ReceiveData()
        {
            byte[] data = new byte[1024];
            int size = clientSocket.Receive(data);
            byte[] responseBuffer = new byte[size]; //Buffer has Specific Size of the message (Removes Extra Padding)
            Array.Copy(data, responseBuffer, size);

            return responseBuffer;
        }

        /// <summary>
        /// Uses Receive Data To convert Byte Received into a String
        /// </summary>
        /// <returns>The Message From Server As a String</returns>
        public static String ReceiveMessage()
        {
            return Encoding.UTF8.GetString(ReceiveData());
        }

        /// <summary>
        /// Converts Message From Server Into UserInfo Object
        /// </summary>
        /// <returns>UserInfo Object</returns>
        public static UserInfo ReceiveUserInfo()
        {
            return (UserInfo) ProtoBufSerialization.ObjectDeserializing(ReceiveData());
        }

        /// <summary>
        /// Converts message from server into DataTable
        /// </summary>
        /// <returns>DataTable from Byte Array</returns>
        public static DataTable ReceiveDataTable()
        {
            return ProtoBufSerialization.DataDeserializing(ReceiveData());
        }
    }
}

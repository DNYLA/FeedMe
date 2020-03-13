using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace FeedMeLogic.Server
{
    public class ServerConnection
    {
        public static List<ItemModel> ItemList = new List<ItemModel>();
        private static readonly int PORT_NO = 4030;
        //static string IP_ADDRESS = "86.180.33.203";
        //static string IP_ADDRESS = "86.181.164.197";
        //static string IP_ADDRESS = "192.168.1.64";
        private static readonly string IP_ADDRESS = "172.16.23.44";

        //static string IP_ADDRESS = "85.255.236.26";

        //Protected Internal Variables are only acessible to the assembly or from containing classes (Anything Outside of FeedMeClient.Functions.Server Is Unable To Access This Variable)
        //Microsoft Documentation: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/accessibility-levels
        protected internal static Socket ServerSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public static string GlobalCommandToSend = "";
        public static bool Connected = false;
        public static string sToken = "";

        public static void InitiailizeConnection(int retryAmount = 0)
        {
            if (!Connected) //No Need to reconnect
            {
                if (retryAmount <= 20) //Maximum Retry Amount of 20
                {
                    try
                    {
                        IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IP_ADDRESS), PORT_NO); //Creates IPEndPoint with Server IP & Port
                        ServerSock.Connect(endPoint); //Connects to Server
                        Connected = true;
                        Send.token = Receive.ReceiveMessage(ServerSock);
                    }
                    catch
                    {
                        Thread.Sleep(500);
                        InitiailizeConnection(retryAmount++); //Reconnect
                    }
                }
                else
                {
                    MessageBox.Show("No Servers Online.");
                }
            }
            else
            {
                Console.WriteLine("Already Connected!");
            }
        }

        public static void CloseConnection()
        {
            ServerSock.Close(500); //Waits 1 second to send any data before closing
        }
    }
}
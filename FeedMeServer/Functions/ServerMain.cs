using FeedMeNetworking;
using FeedMeServer.Functions.Commands;
using FeedMeServer.Functions.Commands.Vendor;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Web.SessionState;

namespace FeedMeServer.Functions
{
    internal class ServerMain
    {
        //Store Each Client in a ClientSocket String Later on instead of "Disposing" of it once it connects

        private const int PORT_NO = 4030;
        private const string IP_ADDRESS = "127.0.0.1";
        public static List<string> bannedIPS = new List<string>();
        public static List<string> clients = new List<string>();
        public static List<string> sessionTokens = new List<string>();
        //Only able to bind to localhost
        //const string IP_ADDRESS = "85.255.236.26";

        private static Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //Move All of this to its own Class

        public static void InitializeClient()
        {
            Console.WriteLine("Starting Server. This Can Take a few minutes...");
            IPAddress IP = GetServerInfo.GetPrivateIP();
            String PubIP = GetServerInfo.GetPublicIP();
            //GetServerInfo.RunAsync();
            //string IPADD = "192.168.1.64";
            string IPADD = "172.16.23.162";
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IPADD), PORT_NO);
            //IPEndPoint endPoint = new IPEndPoint(IP, PORT_NO);
            ServerLogger("Server Initiaizliation Completed.");
            ServerLogger("Searching for Clients...");
            Console.WriteLine($"Public Server IP ADDRESS: {endPoint.ToString()}");
            serverSocket.Bind(endPoint); //Binds the EndPoint to the Socket
            serverSocket.Listen(100); //Backlog of 100 clients

            Socket clientSocket = default(Socket);

            int clientAmount = 0;

            //Creating another Instance of this class
            ServerMain ClassObject = new ServerMain();

            //Searching for clients
            while (true)
            {
                clientAmount++;
                clientSocket = serverSocket.Accept();
                ServerLogger("Client Connected To FeedMe Server!");
                Console.WriteLine("Dumping Client Information & Requests");
                string sessToken = GenerateSessiontoken();
                sessionTokens.Add(sessToken);
                Send.SendMessage(clientSocket, sessToken);
                Thread clientThread = new Thread(new ThreadStart(() => ClassObject.ClientInterface(clientSocket, sessToken)));
                clients.Add(clientSocket.LocalEndPoint.ToString());
                clientThread.Start();
                
            }
        }

        private static string GenerateSessiontoken()
        {
            Random rnd = new Random();
            int length = 20;
            var str = "";
            for (var i = 0; i < length; i++)
            {
                str += ((char)(rnd.Next(1, 26) + 64)).ToString();
            }
            if (sessionTokens.Contains(str))
            {
                return GenerateSessiontoken();
            }
            return str;

        }

        public void ClientInterface(Socket clientSocket, string sessToken)
        {
            bool clientConnected = true; //Add Some Sort of Return method later on
            List<string> reqList = new List<string>();
            while (clientConnected)
            {

                //Console.WriteLine($"Client Ping {PingChecker(clientSocket).ToString()}");
                try
                {
                    string request = Receive.ReceiveMessage(clientSocket);
                    string token = Receive.ReceiveMessage(clientSocket);
                    if (token != sessToken)
                    {
                        return;
                    }
                    switch (request)
                    {
                        default:
                            //Do Stuff
                            //Send.SendMessage(clientSocket, "Invalid request socket killed")
                            string ipadd = clientSocket.LocalEndPoint.ToString();
                            bannedIPS.Add(ipadd);
                            Console.WriteLine("test");
                            clientSocket.Disconnect(false);
                            break;
                        case "Login":
                            LoginAuthentication.LoginHandler(clientSocket);
                            break;
                        case "Register":
                            RegisterAuthentication.RegistrationHandler(clientSocket);
                            break;
                        case "StoreMenuInfo": //Single Command Which Handles all Menu Related commands to prevent 20 different requests in the switch statement
                            StoreMenuHandler.MenuHandler(clientSocket);
                            break;
                        case "StoreInfo":
                            StoreInfo.GetStoreInfo(clientSocket);
                            break;
                        case "UpdateStoreInfo":
                            StoreInfo.UpdateStoreInfo(clientSocket);
                            break;
                        case "ConfirmOrder":
                            OrderHandler.CheckOrder(clientSocket);
                            break;
                        case "CheckForOrder":
                            OrderHandler.CheckForOrders(clientSocket);
                            break;
                        case "GetSpecificOrder":
                            OrderHandler.GetSpecificOrder(clientSocket);
                            break;
                        case "UpdateOrderStatus":
                            OrderHandler.UpdateOrderStatus(clientSocket);
                            break;
                        case "UpdateRefundStatus":
                            OrderHandler.UpdateRefundStatus(clientSocket);
                            break;
                        case "GetCustomerOrder":
                            OrderHandler.GetCustomerOrder(clientSocket);
                            break;
                        case "GetRefunds":
                            OrderHandler.GetRefunds(clientSocket);
                            break;
                        case "GetUserInfo":
                            CustomerHandler.GetCustomerInfo(clientSocket);
                            break;
                        case "UpdateUserInfo":
                            CustomerHandler.UpdateUserInfo(clientSocket);
                            break;
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        public static void ServerLogger(string message)
        {
            Console.WriteLine($"{DateTime.Now}:{message}");
        }

        public static void ServerLogger(string message, string LogType = "Server")
        {
            Console.WriteLine($"{DateTime.Now}:{LogType}:{message}");
        }

        public static void ServerLogger(Socket Client, string message, string LogType = "Server")
        {
            //Console.WriteLine($"{DateTime.Now}:{LogType}:{message} - Ping {PingChecker(Client).ToString()}");
        }
    }
}
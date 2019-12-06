using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FeedMeNetworking;
using FeedMeServer.Functions.Commands;
using FeedMeServer.Functions.Commands.Vendor;

namespace FeedMeServer.Functions
{
    class ServerMain
    {

        //Store Each Client in a ClientSocket String Later on instead of "Disposing" of it once it connects

        const int PORT_NO = 4030;
        const string IP_ADDRESS = "127.0.0.1";

        //Only able to bind to localhost    
        //const string IP_ADDRESS = "85.255.236.26";

        static Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //Move All of this to its own Class
       
        public static void InitializeClient()
        {
            Console.WriteLine("Starting Server. This Can Take a few minutes...");
            IPAddress IP = GetServerInfo.GetPrivateIP();
            String PubIP = GetServerInfo.GetPublicIP();
            //GetServerInfo.RunAsync();
            //string IPADD = "192.168.1.64";
            string IPADD = "127.0.0.1";
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
                Thread clientThread = new Thread(new ThreadStart(() => ClassObject.ClientInterface(clientSocket)));
                clientThread.Start();
            }
        }
        
        public void ClientInterface(Socket clientSocket)
        {
            bool clientConnected = true; //Add Some Sort of Return method later on
            while (clientConnected)
            {
                //Console.WriteLine($"Client Ping {PingChecker(clientSocket).ToString()}");
                try
                {
                    string request = Receive.ReceiveMessage(clientSocket);
                    switch (request)
                    {
                        default:
                            //Do Stuff
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
                        case "ConfirmOrder":
                            OrderHandler.CheckOrder(clientSocket);
                            break;
                        case "CheckForOrder":
                            OrderHandler.CheckForOrders(clientSocket);
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

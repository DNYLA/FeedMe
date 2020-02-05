using FeedMeNetworking;
using FeedMeServer.Functions.Commands;
using FeedMeServer.Functions.Commands.Vendor;
using FeedMeServer.Models;
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
        public static List<Client> clients = new List<Client>();
        public static List<string> tTokens = new List<string>(); //Temporary Session Tokens
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
            string IPADD = "127.0.0.1";
            //string IPADD = "172.16.23.162";
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
                Client clientModel = CreateClientInfo(clientSocket);
                
                Thread clientThread = new Thread(new ThreadStart(() => ClassObject.ClientInterface(clientModel)));
                
                clientThread.Start();
                
            }
        }

        public static string GenerateSessiontoken()
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

        private static Client CreateClientInfo(Socket cSock)
        {
            Client clientInf = new Client();
            clientInf.TToken = GenerateSessiontoken();
            clientInf.TimeConnected = DateTime.Now;
            clientInf.LastResponse = DateTime.Now;
            clientInf.ClientSocket = cSock;

            clients.Add(clientInf);
            tTokens.Add(clientInf.TToken);
            Console.WriteLine(clientInf.TToken + "TToken");

            Send.SendMessage(cSock, clientInf.TToken);

            return clientInf;
        }

        public void ClientInterface(Client clientM)
        {
            bool clientConnected = true; //Add Some Sort of Return method later on
            Socket cSock = clientM.ClientSocket;

            while (clientConnected)
            {

                //Console.WriteLine($"Client Ping {PingChecker(clientSocket).ToString()}");
                try
                {
                    string token = Receive.ReceiveMessage(cSock);
                    string request = Receive.ReceiveMessage(cSock);

                    int lastResp = clientM.GetLastResponseSpan() - DateTime.Now.Minute;

                    Console.WriteLine(clientM.TToken + "TToken");
                    if (lastResp > 5)
                    {
                        //Renew Token
                    }
                    else
                    {
                        Console.WriteLine("Less Dan 5");
                        clientM.LastResponse = DateTime.Now;
                    }

                    if (token == clientM.TToken)
                    {
                        Console.WriteLine("In T Tokens");
                        //Temporary Tokens are only able to Login Or Register
                        switch (request)
                        {
                            default:
                                //Do Stuff
                                //Send.SendMessage(clientSocket, "Invalid request socket killed")
                                //string ipadd = cSock.LocalEndPoint.ToString();
                                break;
                            case "Login":
                                LoginAuthentication.LoginHandler(cSock, ref clientM);
                                break;
                            case "Register":
                                RegisterAuthentication.RegistrationHandler(cSock);
                                break;
                        }
                    }
                    else if (token == clientM.SToken)
                    {
                        //Clients with a Session token can send any command.
                        Console.WriteLine("In S Tokens");
                        switch (request)
                        {
                            case "StoreMenuInfo": //Single Command Which Handles all Menu Related commands to prevent 20 different requests in the switch statement
                                StoreMenuHandler.MenuHandler(cSock);
                                break;
                            case "StoreInfo":
                                StoreInfo.GetStoreInfo(cSock);
                                break;
                            case "UpdateStoreInfo":
                                StoreInfo.UpdateStoreInfo(cSock);
                                break;
                            case "OrderHandling":
                                OrderHandler orderHand = new OrderHandler();
                                orderHand.HandleOrder(ref clientM);
                                break;
                            case "GetUserInfo":
                                CustomerHandler.GetCustomerInfo(cSock);
                                break;
                            case "UpdateUserInfo":
                                CustomerHandler.UpdateUserInfo(cSock);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine(clientM.SToken + "Street Token");
                        //Add Some sort of handling || just leave blank
                        Console.WriteLine("Token No Match");
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
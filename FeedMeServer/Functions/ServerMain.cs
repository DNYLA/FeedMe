using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FeedMeNetworking;
using FeedMeSerialization;
using FeedMeServer.Functions.Commands;

namespace FeedMeServer.Functions
{
    class ServerMain
    {

        //Store Each Client in a ClientSocket String Later on instead of "Disposing" of it once it connects

        const int PORT_NO = 4030;
        const string IP_ADDRESS = "127.0.0.1";
        static Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);



        public static void InitializeClient()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IP_ADDRESS), PORT_NO);
            serverSocket.Bind(endPoint); //Binds the EndPoint to the Socket
            serverSocket.Listen(100); //Backlog of 100 clients
            ServerLogger("Sucessfully Started");
            ServerLogger("Searching for Clients...");

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
                    }

                }
                catch (Exception)
                {

                }
            }
        }

        public static void ServerLogger(string message, string LogType = "Server")
        {
            Console.WriteLine($"{DateTime.Now}:{LogType}:{message}");
        }
    }
}

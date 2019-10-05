using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FeedMeSerialization;
using FeedMeServer.Functions.Commands;

namespace FeedMeServer.Functions
{
    class ServerMain
    {

        //Store Each Client in a ClientSocket String Later on instead of "Disposing" of it once it connects

        static int PORT_NO = 4030;
        static string IP_ADDRESS = "127.0.0.1";
        static Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);



        public static void InitializeClient()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IP_ADDRESS), PORT_NO);
            serverSocket.Bind(endPoint); //Binds the EndPoint to the Socket
            serverSocket.Listen(100); //Backlog of 100 clients
            Console.WriteLine("FeedMe Server Successfully loaded");
            Console.WriteLine("FeedMe Server: Searching For Clients");

            Socket clientSocket = default(Socket);

            int clientAmount = 0;
            
            //Creating another Instance of this class
            ServerMain ClassObject = new ServerMain();

            

            //Searching for clients
            while (true)
            {
                clientAmount++;
                clientSocket = serverSocket.Accept();
                Console.WriteLine("Client Connected To FeedMe Server. Dumping Client Information & Requests to Seperate Folder");
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
                    string request = ReceiveData(clientSocket);
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

        public static String ReceiveData(Socket clientSocket)
        {
            byte[] clientMessage = new byte[1024]; //Creating new Byte Array to store message. 1024 Bytes because the data could be large
            int size = clientSocket.Receive(clientMessage); //Receives the message & stores it in clientMessage & also retreives amount of bytes the message takes up
            byte[] choppedMessage = new byte[size]; //Creating a new Byte Array that is exact size of message to prevent extra padded 0's on the original Byte Array

            if (choppedMessage.Length == 0)
            {
                return string.Empty; //If No Request was received return empty string
            }

            Array.Copy(clientMessage, choppedMessage, size); //Copying the Data from clientMessage Array to chopped Array using the Size received to remove extra padded 0's

            return Encoding.UTF8.GetString(choppedMessage); //Converts Byte Array into String encoded in UTF
        }

        public static void ServerLogger(string message)
        {
            Console.WriteLine(DateTime.Now + ":Customer: " + message);
        }
    }
}

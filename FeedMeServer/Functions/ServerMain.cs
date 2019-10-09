using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
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

        //Only able to bind to localhost    
        //const string IP_ADDRESS = "85.255.236.26";

        static Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //Move All of this to its own Class
        private static IPAddress GetPrivateIP()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress myIp = ipHostInfo.AddressList[0];
            foreach (IPAddress ip in ipHostInfo.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    myIp = ip;
                    Console.WriteLine($"{ip.ToString()}:{PingChecker(myIp).ToString()}");
                }
            }

            return myIp;

        }

        private static void GetPublicIP()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://ifconfig.me");

            request.UserAgent = "curl"; // this will tell the server to return the information as if the request was made by the linux "curl" command

            string publicIPAddress;

            request.Method = "GET";
            using (WebResponse response = request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    publicIPAddress = reader.ReadToEnd();
                }
            }
            Console.WriteLine(publicIPAddress.Replace("\n", ""));
        }
        public static void InitializeClient()
        {

            IPAddress IP = GetPrivateIP();
            //string IPADD = "192.168.1.64";
            string IPADD = "127.0.0.1";
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IPADD), PORT_NO);
            //IPEndPoint endPoint = new IPEndPoint(IP, PORT_NO);
            Console.WriteLine($"IP ADDRESS: {endPoint.ToString()}");
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

        public static int PingChecker(IPAddress IP)
        {
            //https://stackoverflow.com/questions/3318610/how-to-get-client-ip-using-socket-programming-c-sharp
            //IPAddress LIP = IPAddress.Parse(((IPEndPoint)Client.RemoteEndPoint).Address.ToString());
            

            Ping PingChecker = new Ping();
            PingReply PR = PingChecker.Send(IP);

            if (PR.Status.ToString().Equals("Success"))
            {
                return Convert.ToInt32(PR.RoundtripTime);
            }
            else
            {
                return -1;
            }
            
        }
    }
}

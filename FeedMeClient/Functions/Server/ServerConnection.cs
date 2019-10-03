using System;
using System.Collections.Generic;
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

        public static void AuthenticateLogin(string username, string password)
        {
            clientSocket.Send(Encoding.UTF8.GetBytes("Login"), 0, "Login".Length, SocketFlags.None);

            clientSocket.Send(Encoding.UTF8.GetBytes(username), 0, username.Length, SocketFlags.None);

            Thread.Sleep(100); //If Data is sent to quickly the server might read seperate messages as one string sometimes

            clientSocket.Send(Encoding.UTF8.GetBytes(password), 0, password.Length, SocketFlags.None);

            byte[] responseFromServer = new byte[1024];
            int size = clientSocket.Receive(responseFromServer);

            byte[] responseBuffer = new byte[size];

            Array.Copy(responseFromServer, responseBuffer, size);

            string valuefromserver = Encoding.UTF8.GetString(responseBuffer);
            MessageBox.Show(valuefromserver);
        }
    }
}

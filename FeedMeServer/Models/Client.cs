using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeServer.Models
{
    class Client
    {

        private string tToken; //Temporary Token assigned on connection. (Temp Tokens limit the client to only Registering & Logging in)
        private string sToken; //Session Token (Given After user Logged in)
        private int clientID; //Database ID for the client
        private bool isVendor;
        private DateTime timeConnected;
        private DateTime lastResponse;
        private Socket clientSocket;

        //Encapsulating propeties
        public string TToken { get => tToken; set => tToken = value; }
        public string SToken { get => sToken; set => sToken = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public bool IsVendor { get => isVendor; set => isVendor = value; }
        public DateTime TimeConnected { get => timeConnected; set => timeConnected = value; }
        public DateTime LastResponse { get => lastResponse; set => lastResponse = value; }
        public Socket ClientSocket { get => clientSocket; set => clientSocket = value; }

        public int GetLastResponseSpan()
        {
            return lastResponse.Minute;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace FeedMeServer.Functions
{
    internal class GetServerInfo
    {
        public static IPAddress GetPrivateIP()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress myIp = ipHostInfo.AddressList[0];
            foreach (IPAddress ip in ipHostInfo.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    myIp = ip;
                    //Console.WriteLine($"{ip.ToString()}:{PingChecker(myIp).ToString()}");
                }
            }

            return myIp;
        }

        public static string GetPublicIP()
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
            //Console.WriteLine(publicIPAddress.Replace("\n", ""));
            return publicIPAddress.Replace("\n", "");
        }

        //https://docs.microsoft.com/en-us/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client
        private static HttpClient client = new HttpClient();

        public static async Task<Uri> CreateServerAsync(ServerInformation ServerData)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/servers",
                ServerData);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            response.EnsureSuccessStatusCode();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            // return URI of the created resource.
            return response.Headers.Location;
        }

        private static async Task<Boolean> TT()
        {
            var values = new Dictionary<string, string>
            {
                { "thing1", "hello" },
                { "thing2", "world" }
            };

            ServerInformation SI = new ServerInformation
            {
                Name = "John",
                Address = "66.44.22.33",
                Port = "33",
                Country = "UK",
                UpTime = DateTime.Now,
                UserCount = 55
            };

            //var content = new FormUrlEncodedContent(SI);

            var response = await client.PostAsJsonAsync("http://localhost:44362/apis/servers", SI);

            var responseString = await response.Content.ReadAsStringAsync();
            return true;
        }

        private static async Task<Boolean> AddServer()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:44362/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(30);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            try
            {
                // Create a new product
                ServerInformation SI = new ServerInformation
                {
                    Name = "John",
                    Address = "66.44.22.33",
                    Port = "33",
                    Country = "UK",
                    UpTime = DateTime.Now,
                    UserCount = 55
                };
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                var url = await CreateServerAsync(SI);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                Console.WriteLine($"Created at {url}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Fookking Error");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException.Message);
            }

            return true;
        }

        public static bool RunAsync()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            Thread.Sleep(4000);
            bool APIResponse = false;

            Task task = Task.Factory.StartNew(() =>
            {
                //APIResponse = AddServer().Result;
                APIResponse = TT().Result;
            });

            task.Wait();

            return APIResponse;
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
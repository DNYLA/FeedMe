using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeServer
{
    class ServerInformation
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string Port { get; set; } = "";
        public string Country { get; set; } = "";
        public DateTime UpTime { get; set; } = DateTime.Now;
        public int UserCount { get; set; } = 0;
    }
}

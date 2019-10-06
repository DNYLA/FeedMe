using FeedMeWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FeedMeWebAPI.Controllers
{
    public class ServersController : ApiController
    {
        List<Server> Servers = new List<Server>();
        public ServersController()
        {
            Servers.Add(new Server { Id = 0, Name = "London Server", Address = "127.0.0.1", Port = "4030", Country = "UK", UpTime = DateTime.Now, UserCount = 15 });
            Servers.Add(new Server { Id = 0, Name = "US Server", Address = "86.55.153.132", Port = "4030", Country = "US", UpTime = DateTime.Now, UserCount = 5 });
            Servers.Add(new Server { Id = 0, Name = "Spanish Server", Address = "77.04.32.12", Port = "4030", Country = "Spain", UpTime = DateTime.Now, UserCount = 1 });
        }
        // GET: api/Servers
        public List<Server> Get()
        {
            return Servers;
        }

        // GET: api/Servers/5
        public Server Get(int id)
        {
            return Servers.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/Servers
        public void Post(Server server)
        {
            Servers.Add(server);
        }

        // PUT: api/Servers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Servers/5
        public void Delete(int id)
        {
        }
    }
}

using FeedMeWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Http;

namespace FeedMeWebAPI.Controllers
{
    public class ServersController : ApiController
    {
        public ServersController()
        {
            //Removed as Its not needed anymore
        }

        // GET: api/Servers
        public List<Server> Get()
        {
            DataTable dt = DAL.ExecCommand("SELECT * FROM SERVERS");
            List<Server> Servers = new List<Server>();
            foreach (DataRow row in dt.Rows)
            {
                var s = new Server(); //Must Be Initialized inside. If Initialized outside it will just overwrite other data.
                Console.WriteLine(row[0].ToString());
                s.Id = Convert.ToInt32(row["ServerID"].ToString());
                s.Name = row[1].ToString();
                s.Address = row[2].ToString();
                s.Port = row[3].ToString();
                s.Country = row[4].ToString();
                s.TimeStarted = DateTime.Parse(row[5].ToString());
                s.UserCount = Convert.ToInt32(row[6].ToString());
                Servers.Add(s);
            }
            return Servers;
        }

        // GET: api/Servers/5
        public Server Get(int id)
        {
            DataTable dt = DAL.ExecCommand($"SELECT * FROM Servers WHERE ServerID = {id}");
            Server s = new Server();
            s.Id = Convert.ToInt32(dt.Rows[0][0].ToString());
            s.Name = dt.Rows[0][1].ToString();
            s.Address = dt.Rows[0][2].ToString();
            s.Port = dt.Rows[0][3].ToString();
            s.Country = dt.Rows[0][4].ToString();
            s.TimeStarted = DateTime.Parse(dt.Rows[0][5].ToString());
            s.UserCount = Convert.ToInt32(dt.Rows[0][6].ToString());

            return s;
        }

        // POST: api/Servers
        public void Post(Server s)
        {
            string date = s.TimeStarted.ToString("yyyy-MM-dd H:mm:ss");
            string sqlQuery = ($@"INSERT INTO SERVERS(Name, Address, Port, Country, TimeStarted, LastPing)
                                  VALUES ('{s.Name}', '{s.Address}', '{s.Port}', '{s.Country}', '{date}', '{date}')");

            DAL.ExecCommand(sqlQuery);
        }

        // PUT: api/Servers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Servers/5
        public void Delete(int id)
        {
            DAL.ExecCommand($"DELETE FROM Servers WHERE ServerID = {id};");
        }
    }
}
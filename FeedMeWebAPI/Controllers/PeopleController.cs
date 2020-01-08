using FeedMeWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FeedMeWebAPI.Controllers
{
    /// <summary>
    /// Information about every Person
    /// </summary>
    public class PeopleController : ApiController
    {
        private List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Dan", LastName = "John", Id = 1 });
            people.Add(new Person { FirstName = "Joe", LastName = "Ron", Id = 2 });
            people.Add(new Person { FirstName = "Zue", LastName = "Landy", Id = 3 });
        }

        /// <summary>
        /// Gets a list of all first names
        /// </summary>
        /// <returns>List of First Names</returns>
        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<String> output = new List<String>();
            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }

        // GET: api/People
        //https://www.youtube.com/watch?v=vN9NRqv7xmY
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person value)
        {
            people.Add(value);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            people.Remove(people.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}
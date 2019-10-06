using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedMeWebAPI.Models
{
    /// <summary>
    /// Represents one specific person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// ID from SQL
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// Users First Name
        /// </summary>
        public string FirstName { get; set; } = "";
        /// <summary>
        /// Users Last Name
        /// </summary>
        public string LastName { get; set; } = "";
    }
}
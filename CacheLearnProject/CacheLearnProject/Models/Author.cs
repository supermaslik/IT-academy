using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CacheLearnProject.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }

        public override string ToString()
        {
            return $"{Id} : {FirstName} {LastName}";
        }
    }
}
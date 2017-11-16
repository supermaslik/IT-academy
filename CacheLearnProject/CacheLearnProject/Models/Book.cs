using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CacheLearnProject.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AutorId { get; set; }
        public decimal Price { get; set; }
        public Author Author { get; set; }
        public override string ToString()
        {
            return $"{Id} : {Name}, {Price}";
        }
    }
}
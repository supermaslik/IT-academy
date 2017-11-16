using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CacheLearnProject.Models;
using System.Data.Entity.Infrastructure;

namespace CacheLearnProject.Models.Db_content
{
    public class DataBaseConnection : DbContext
    {
        public DataBaseConnection() : base("DefaultConnection")
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
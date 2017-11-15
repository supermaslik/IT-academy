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
        public DataBaseConnection() : base("default")
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Autor> Autors { get; set; }
    }
}
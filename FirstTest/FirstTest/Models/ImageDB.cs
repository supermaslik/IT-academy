using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FirstTest.Models;
namespace FirstTest.Controllers
{
    public class ImageDB : DbContext
    {
        public ImageDB() : base()
        { }
        public DbSet<ImageLinkInfo> ImageLinksInfo { get; set; }
    }
}
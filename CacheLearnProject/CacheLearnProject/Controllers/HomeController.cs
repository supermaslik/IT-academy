using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CacheLearnProject.Models.Db_content;
using CacheLearnProject.Models;

namespace CacheLearnProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new DataBaseConnection())
            {
                var Authors = db.Authors.ToList();
                if (Authors == null)
                    return HttpNotFound();
                return View(Authors);
            }
        }
        [OutputCache(Duration = 180, Location =System.Web.UI.OutputCacheLocation.Downstream)]
        public ActionResult LinkToAuthorsBooks(Author author)
        {
            if(author !=null)
            {
                using (var db = new DataBaseConnection())
                {
                    var AuthorsBooks = db.Books.Where(x => x.AuthorId == author.Id).ToList();
                    if (AuthorsBooks == null)
                        return HttpNotFound();
                    ViewBag.Author = author.FirstName + author.LastName;
                    return View(AuthorsBooks);
                }
            }
            return HttpNotFound();
        }
    }
}
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
                var Autors = db.Autors;
                if (Autors == null)
                    return HttpNotFound();
                return View(Autors);
            }
        }
    }
}
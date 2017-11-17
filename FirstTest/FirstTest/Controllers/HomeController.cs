using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstTest.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        [Route("Index/page/{page?}")]
        public ActionResult Index(int page = 1)
        {
            return View(page);
        }




        public ActionResult PreviousPage()
        {
            return RedirectToAction("Index", 1);
        }
        public ActionResult NestPage()
        {
            return RedirectToAction("Index", 1);
        }
    }
}
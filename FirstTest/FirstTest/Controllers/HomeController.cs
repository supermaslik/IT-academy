using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstTest.Models;

namespace FirstTest.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        [Route("Index/page/{page?}")]
        public ActionResult Index(int page = 1)
        {
            page = (page < 1) ? 1 : page;
            page = (page > 5) ? 5 : page;
            return View(page);
        }

        [ChildActionOnly]
        public ActionResult ShowData(int page = 1)
        {
            ImageLinkInfo Image = null;
            using (ImageDB db = new ImageDB())
            {
                Image = db.ImageLinksInfo.First();
            }
                return PartialView(Image);
        }
    }
}
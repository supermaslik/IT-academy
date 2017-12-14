using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstTest.Models;
using System.Data.Entity;

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

        [Route("Data/{page?}")]
        [ChildActionOnly]
        public ActionResult ShowData(int page = 1)
        {
            List<ImageLinkInfo> Image = new List<ImageLinkInfo>();
            using (ImageDB db = new ImageDB())
            {
                Image = db.ImageLinksInfo.ToList();

                Image = Image.Skip((page - 1) * 3).Take(3).ToList();
            }
                return PartialView(Image);
        }

        [HttpGet]
        [Route("Data/Edit/{id?}")]
        public ActionResult EditData(int? id)
        {
            if(id == null)
                return HttpNotFound();

            using (var db = new ImageDB())
            {
                var Model = db.ImageLinksInfo.Find(id);
                if (Model != null)
                    return View(Model);
            }

            return HttpNotFound();
        }

        [HttpPost]
        [Route("Data/Edit/{id?}")]
        public ActionResult EditData(ImageLinkInfo model)
        {
            using (var db = new ImageDB())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}
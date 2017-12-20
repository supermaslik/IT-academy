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
        public ActionResult Index(int? page = 1)
        {
            if (!page.HasValue)
                page = 1;
            page = (page < 1) ? 1 : page;
            page = (page > 5) ? 5 : page;
            return View(page.Value);
        }

        [Route("Data/{page?}")]
        [ChildActionOnly]
        public ActionResult ShowData(int page = 1)
        {
            List<ImageLinkInfo> Images = new List<ImageLinkInfo>();
            using (ImageDB db = new ImageDB())
            {
                Images = db.ImageLinksInfo.ToList();

                Images = Images.Skip((page - 1) * 3).Take(3).ToList();
            }
            ViewBag.page = page;
                return PartialView(Images);
        }

        [HttpGet]
        [Route("Data/Edit/{id?}")]
        public ActionResult EditData(int? id)
        {

            if(id == null )
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
                return RedirectToAction("Index", new { page = 1 });
            }
        }

        [HttpGet]
        [Route("Data/Delete/{id?}")]
        public ActionResult DeleteData(int? id)
        {
            if (id != null)
            using (var db = new ImageDB())
            {
                var model = db.ImageLinksInfo.Find(id);
                if (model != null)
                    return View(model);
            }
            return HttpNotFound();
        }

        [HttpPost, ActionName("DeleteData")]
        [Route("Data/Delete")]
        public ActionResult DeleteDataConfirmed(ImageLinkInfo model)
        {
            using (var db = new ImageDB())
            {
                var modelToDelete = db.ImageLinksInfo.Find(model.Id);
                if(modelToDelete != null)
                {
                    db.ImageLinksInfo.Remove(modelToDelete);
                    db.SaveChanges();
                    return RedirectToAction("Index", new { page = 1 });
                }
            }
            return HttpNotFound();
        }

        [HttpGet]
        [Route("Data/Add")]
        public ActionResult AddData()
        {
            return View();
        }

        [HttpPost]
        [Route("Data/Add")]
        public ActionResult AddData(ImageLinkInfo model)
        {
            using (var db = new ImageDB())
            {
                db.Entry(model).State = EntityState.Added;
                db.SaveChanges();
            }
            return RedirectToAction("Index", new { page = 1 });
        }
    }
}
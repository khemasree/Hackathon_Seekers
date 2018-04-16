using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FavDeals.Models; 

namespace FavDeals.Controllers
{
    public class HomeController : Controller
    {
        masterEntities1 dbContext = new masterEntities1();
        public ActionResult Index()
        {
            List<Deal> list = dbContext.Deals.ToList();
            //TempData["list"] = list;
            return View(list);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            List<Deal> list = dbContext.Deals.ToList();
            //TempData["list"] = list;
            return View(list);
        }

        [HttpPost]
        public ActionResult Add(Deal obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbContext.Deals.Add(obj);
                    dbContext.SaveChanges();
                }
            }
            catch(Exception ex)
            {

            }
            //return View("About",TempData["List"]);
            return RedirectToAction("About");
        }

        public ActionResult Edit(Deal obj)
        {
            Deal d = dbContext.Deals.Where(y => y.DId == obj.DId).FirstOrDefault();
            d.DSource = obj.DSource;
            d.DProduct = obj.DProduct;
            d.DLink = obj.DLink;
            d.DOffPrice = obj.DOffPrice;
            d.DOrgPrice = obj.DOrgPrice;
            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            string message = "Success";
            return Json(message, JsonRequestBehavior.AllowGet);
            //return RedirectToAction("About");
        }

        public ActionResult Delete(int id)
        {
            Deal d = dbContext.Deals.Where(y => y.DId == id).FirstOrDefault();
            dbContext.Deals.Remove(d);
            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                
            }
            string message = "Success";
            return Json(message, JsonRequestBehavior.AllowGet);
            //return RedirectToAction("About");
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
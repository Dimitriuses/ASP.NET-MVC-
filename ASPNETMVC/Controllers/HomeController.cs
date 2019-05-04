using ASPNETMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC.Controllers
{
    public class HomeController : Controller
    {
        CarContext db = new CarContext();
        public ActionResult Index()
        {
            IEnumerable<Car> cars = db.Cars;
            ViewBag.Cars = cars;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.CarId = id;
            ViewBag.Car = db.Cars.Find(id);
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            db.Purchases.Add(purchase);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Дякую," + purchase.Person + ", за покупку!";
        }
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}
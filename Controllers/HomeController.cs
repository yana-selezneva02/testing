using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class HomeController : Controller
    {
        CoffeeContext db = new CoffeeContext();
        private readonly Models.Coffee coffee1;

        public ActionResult Index()
        {
            return View(db.Coffee);
        }
        [HttpPost]
        public ActionResult EditFilm(CoffeeContext coffee)
        {
            db.Entry(coffee).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
            protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        [HttpGet]
        public ActionResult Create()
        {
            SelectList coffee = new SelectList(db.Coffee, "Id", "Name");
            ViewBag.Coffee = coffee;
            return View();
        }

        [HttpPost]
        public ActionResult Create(CoffeeContext coffee)
        {
           Models.Coffee Coffee = db.Coffee.Add(coffee1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.CoffeeId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!Номер Вашего заказа будет выведен на табло!";
        }
        [HttpGet]
        public ActionResult Login(int? id)
        {
            ViewBag.CoffeeId = id;
            return View();
        }
        [HttpGet]
        public ActionResult PersonalAccount(int? id)
        {
            ViewBag.CoffeeId = id;
            return View();
        }

    }
    }
    
    
    

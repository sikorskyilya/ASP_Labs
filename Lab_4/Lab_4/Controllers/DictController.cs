using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_4.Models;

namespace Lab_4.Controllers
{
    public class DictController : Controller
    {
        TelephoneContext db = new TelephoneContext();
        // GET: Dict
        public ActionResult Index()
        {
            ViewBag.Select = db.Select();
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            ViewBag.Select = db.Select();
            return View();
        }

        [HttpPost]
        public ActionResult Add(string surname, int number)
        {
            db.Insert(surname, number);
            ViewBag.Select = db.Select();
            return View("Index");
        }
        [HttpGet]
        public ActionResult Update()
        {
            ViewBag.Select = db.Select();
            return View();
        }

        [HttpPost]
        public ActionResult Update(int id, string surname, int number)
        {
            db.Update(id, surname, number);
            ViewBag.Select = db.Select();
            return View("Index");
        }
        [HttpGet]
        public ActionResult Delete()
        {
            ViewBag.Select = db.Select();
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            db.Delete(id);
            ViewBag.Select = db.Select();
            return View("Index");
        }
    }
}
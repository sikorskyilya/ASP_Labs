using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_3.Controllers
{
    public class DictController : Controller
    {
        Models.TelephoneDictionary telephoneDictionary = new Models.TelephoneDictionary();
        // GET: Dict
        public ActionResult Index()
        {
            ViewBag.getAll = telephoneDictionary.getAll();
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            ViewBag.getAll = telephoneDictionary.getAll();
            return View();
        }

        [HttpPost]
        public ActionResult Add(string surname, int number)
        {
            telephoneDictionary.insert(surname, number);
            ViewBag.getAll = telephoneDictionary.getAll();
            return View("Index");
        }
        [HttpGet]
        public ActionResult Update()
        {
            ViewBag.getAll = telephoneDictionary.getAll();
            return View();
        }

        [HttpPost]
        public ActionResult Update(int id, string surname, int number)
        {
            telephoneDictionary.update(id, surname, number);
            ViewBag.getAll = telephoneDictionary.getAll();
            return View("Index");
        }
        [HttpGet]
        public ActionResult Delete()
        {
            ViewBag.getAll = telephoneDictionary.getAll();
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            telephoneDictionary.delete(id);
            ViewBag.getAll = telephoneDictionary.getAll();
            return View("Index");
        }
    }
}
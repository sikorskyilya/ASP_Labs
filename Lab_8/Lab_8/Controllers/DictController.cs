using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab_8.Controllers
{
    public class DictController : Controller
    {
        Models.IPhoneDictionary repo;
        public DictController(Models.IPhoneDictionary _repo)
        {
            repo = _repo;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Select = repo.Select();
            return View();
        }

        [HttpGet("[action]")]
        public ActionResult Add()
        {
            ViewBag.Select = repo.Select();
            return View();
        }

        [HttpPost("[action]")]
        public ActionResult Add(string surname, int number)
        {
            repo.Insert(surname, number);
            ViewBag.Select = repo.Select();
            return RedirectToAction("Index");
        }

        [HttpGet("[action]")]
        public ActionResult Update()
        {
            ViewBag.Select = repo.Select();
            return View();
        }

        [HttpPost("[action]")]
        public ActionResult Update(int id, string surname, int number)
        {
            repo.Update(id, surname, number);
            ViewBag.Select = repo.Select();
            return RedirectToAction("Index");
        }

        [HttpGet("[action]")]
        public ActionResult Delete()
        {
            ViewBag.Select = repo.Select();
            return View();
        }

        [HttpPost("[action]")]
        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            ViewBag.Select = repo.Select();
            return RedirectToAction("Index");
        }
    }
}
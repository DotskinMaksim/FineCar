using FineCar.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FineCar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        FineContext db = new FineContext();
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        // Отображение списка штрафов
        public ActionResult Fines()
        {
            IEnumerable<Fine> fines = db.Fines.ToList();
            return View(fines);
        }

        // Отображение страницы для создания нового штрафа (GET)
        [HttpGet]
        public ActionResult FineCreate()
        {
            return View();
        }

        // Создание нового штрафа (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FineCreate(Fine fine)
        {
            if (ModelState.IsValid)
            {
                db.Fines.Add(fine);
                db.SaveChanges();
                return RedirectToAction("Fines");
            }
            return View(fine);
        }

        // Отображение страницы удаления штрафа (GET)
        [HttpGet]
        public ActionResult FineDelete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Fine fine = db.Fines.Find(id);
            if (fine == null)
            {
                return HttpNotFound();
            }

            return View(fine);
        }

        // Подтверждение удаления штрафа (POST)
        [HttpPost, ActionName("FineDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult FineDeleteConfirmed(int id)
        {
            Fine fine = db.Fines.Find(id);
            if (fine != null)
            {
                db.Fines.Remove(fine);
                db.SaveChanges();
            }
            return RedirectToAction("Fines");
        }

        // Отображение страницы редактирования штрафа (GET)
        [HttpGet]
        public ActionResult FineEdit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Fine fine = db.Fines.Find(id);
            if (fine == null)
            {
                return HttpNotFound();
            }

            return View(fine);
        }

        // Сохранение отредактированного штрафа (POST)
        [HttpPost, ActionName("FineEdit")]
        [ValidateAntiForgeryToken]
        public ActionResult Fine_EditConfirmed(Fine fine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Fines");
            }
            return View(fine);
        }

        // Отображение страницы с деталями штрафа (GET)
        [HttpGet]
        public ActionResult FineDetails(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Fine fine = db.Fines.Find(id);
            if (fine == null)
            {
                return HttpNotFound();
            }

            return View(fine);
        }
    }
}

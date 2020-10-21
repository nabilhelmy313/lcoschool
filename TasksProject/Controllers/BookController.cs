using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasksProject.Models;

namespace TasksProject.Controllers
{
    
    public class BookController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        [HttpGet]
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Upload()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file,Book book)
        {

            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                file.SaveAs(path);
            }
            return View(book);
        }

        [HttpGet]
        public ActionResult Download()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BuildMyPC.Models;

namespace BuildMyPC.Controllers
{
    public class StorageController : Controller
    {
        private ApplicationDbContext _context;

        public StorageController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Storage
        public ActionResult Index()
        {
            var storage = _context.Storage.ToList();

            return View(storage);
        }

        public ActionResult Details(int id)
        {

            var storage = _context.Storage.Include(c => c.Brand).SingleOrDefault(c => c.Id == id);
            if (storage == null)
                return HttpNotFound();

            return View(storage);
        }

        public ActionResult Addstorage(Storage storage)
        {
            Session["storage"] = storage;
            Session["storagename"] = storage.Name;

            return RedirectToAction("List", "Home");
        }
    }
}
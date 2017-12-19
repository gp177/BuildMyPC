using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BuildMyPC.Models;

namespace BuildMyPC.Controllers
{
    public class MotherboardController : Controller
    {
        private ApplicationDbContext _context;

        public MotherboardController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Motherboard
        public ActionResult Index()
        {
            var motherboard = _context.Motherboards.ToList();

            return View(motherboard);
        }

        public ActionResult Details(int id)
        {

            var motherboards = _context.Motherboards.Include(c => c.Brand).SingleOrDefault(c => c.Id == id);
            if (motherboards == null)
                return HttpNotFound();

            return View(motherboards);
        }

        public ActionResult Addmotherboard(Motherboard motherboard)
        {
            Session["motherboard"] = motherboard;
            Session["motherboardname"] = motherboard.Name;

            return RedirectToAction("List", "Home");
        }
    }
}
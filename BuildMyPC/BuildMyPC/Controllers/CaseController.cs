using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BuildMyPC.Models;

namespace BuildMyPC.Controllers
{
    public class CaseController : Controller
    {

        private ApplicationDbContext _context;

        public CaseController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Case
        public ActionResult Index()
        {

            var cases = _context.Cases.ToList();

            return View(cases);
        }

        public ActionResult Details(int id)
        {

            var cases = _context.Cases.Include(c => c.Brand).SingleOrDefault(c => c.Id == id);
            if (cases == null)
                return HttpNotFound();

            return View(cases);
        }

        public ActionResult AddCase(Case cases)
        {
            Session["cases"] = cases;
            Session["casesname"] = cases.Name;

            return RedirectToAction("List", "Home");
        }
    }
}
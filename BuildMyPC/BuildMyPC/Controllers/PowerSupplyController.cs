using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BuildMyPC.Models;

namespace BuildMyPC.Controllers
{
    public class PowerSupplyController : Controller
    {
        private ApplicationDbContext _context;

        public PowerSupplyController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: PowerSupply
        public ActionResult Index()
        {
            var powersupply = _context.PowerSupplies.ToList();

            return View(powersupply);
        }

        public ActionResult Details(int id)
        {

            var powersupply = _context.PowerSupplies.Include(c => c.Brand).SingleOrDefault(c => c.Id == id);
            if (powersupply == null)
                return HttpNotFound();

            return View(powersupply);
        }

        public ActionResult Addpowersupply(PowerSupply powersupply)
        {
            Session["powersupply"] = powersupply;

            return RedirectToAction("List", "Home");
        }
    }
}
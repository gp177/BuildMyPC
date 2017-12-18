using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BuildMyPC.Models;

namespace BuildMyPC.Controllers
{
    public class CPUController : Controller
    {
        private ApplicationDbContext _context;

        public CPUController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: CPU
        public ActionResult Index()
        {

            var cpus = _context.CPUS.ToList();

            return View(cpus);
        }

        public ActionResult Details(int id)
        {
            
            var cpus = _context.CPUS.Include(c => c.Brand).SingleOrDefault(c => c.Id == id);
            if (cpus == null)
                return HttpNotFound();

            return View(cpus);
        }
        
        public ActionResult AddCpu(CPU cpu)
        {
            Session["Cpu"] = cpu.Id;

            return RedirectToAction("List", "Home");
        }



    }
}
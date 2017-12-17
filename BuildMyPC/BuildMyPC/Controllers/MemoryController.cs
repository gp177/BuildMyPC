using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BuildMyPC.Models;

namespace BuildMyPC.Controllers
{
    public class MemoryController : Controller
    {

        private ApplicationDbContext _context;

        public MemoryController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Memory
        public ActionResult Index()
        {
            var memory = _context.Memory.ToList();

            return View(memory);
        }

        public ActionResult Details(int id)
        {

            var memory = _context.Memory.Include(c => c.Brand).SingleOrDefault(c => c.Id == id);
            if (memory == null)
                return HttpNotFound();

            return View(memory);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuildMyPC.Models;
using BuildMyPC.ViewModels;

namespace BuildMyPC.Controllers
{
    public class BuildController : Controller
    {
        private ApplicationDbContext _context;

        public BuildController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: Build
        public ActionResult Index()
        {

            var id = (Int32)Session["Cpu"];
            var cpu =_context.CPUS.Where(m=>m.Id==id).SingleOrDefault();

            var build = new BuildViewModel()
            {
                cpu = cpu
                
            };
            return View("Index", build);
        }
    }
}
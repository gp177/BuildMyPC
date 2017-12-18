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

            
            var build = new BuildViewModel()
            {
                cpu = (CPU)Session["Cpu"]

        };
            return View("Index", build);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuildMyPC.Models;

namespace BuildMyPC.Controllers
{
    public class BuildController : Controller
    {
        // GET: Build
        public ActionResult Index()
        {
            Build build = new Build();
            build.CPU.Id = (Int32)Session["Cpu"];
            int b = build.CPU.Id;
            return View(build);
        }
    }
}
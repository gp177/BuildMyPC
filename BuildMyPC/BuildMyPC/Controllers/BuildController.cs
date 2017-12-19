using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuildMyPC.Models;
using BuildMyPC.ViewModels;
using System.Data.Entity;

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
            Case Case = (Case)Session["cases"];
            CPU cpu = (CPU)Session["Cpu"];
            VideoCard videoCard = (VideoCard)Session["videocard"];
            Motherboard motherBoard = (Motherboard)Session["motherboard"];
            PowerSupply powerSupply=(PowerSupply)Session["powersupply"];
            Memory memory=(Memory)Session["memory"];
            Storage storage=(Storage)Session["storage"];
            var build = new BuildViewModel()
            {
                
                Cpu = cpu,
                CpuBrand = _context.Brands.Where(m => m.Id == cpu.BrandId).SingleOrDefault(),
                
                Case = Case,
                CaseBrand = _context.Brands.Where(m => m.Id == Case.BrandId).SingleOrDefault(),

                Videocard = videoCard,
                VideocardBrand = _context.Brands.Where(m => m.Id == videoCard.BrandId).SingleOrDefault(),

                Motherboard  = motherBoard,
                MotherboardBrand = _context.Brands.Where(m => m.Id == motherBoard.BrandId).SingleOrDefault(),

                Powersupply = powerSupply,
                PowersupplyBrand = _context.Brands.Where(m => m.Id == powerSupply.BrandId).SingleOrDefault(),

                Memory = memory,
                MemoryBrand = _context.Brands.Where(m => m.Id == memory.BrandId).SingleOrDefault(),

                Storage = storage,
                StorageBrand = _context.Brands.Where(m => m.Id == storage.BrandId).SingleOrDefault()

            };
            ViewBag.Total = cpu.Price + Case.Price + videoCard.Price + motherBoard.Price + powerSupply.Price + memory.Price + storage.Price;
            return View("Index", build);
        }
     
        public ActionResult Save()
        {
            Build build = new Build();
            Case Case = (Case)Session["cases"];
            CPU cpu = (CPU)Session["Cpu"];
            VideoCard videoCard = (VideoCard)Session["videocard"];
            Motherboard motherBoard = (Motherboard)Session["motherboard"];
            PowerSupply powerSupply = (PowerSupply)Session["powersupply"];
            Memory memory = (Memory)Session["memory"];
            Storage storage = (Storage)Session["storage"];

            
            build.CaseId = Case.Id;
            build.MemoryId = memory.Id;
            build.VideoCardId = videoCard.Id;
            build.MotherboardId = motherBoard.Id;
            build.PowerSupplyId = powerSupply.Id;
            build.CPUId = cpu.Id;
            build.StorageId = storage.Id;

            _context.Builds.Add(build);
            _context.SaveChanges();

            return RedirectToAction("AllBuilds");
        }

        public ActionResult AllBuilds()
        {
            var builds = _context.Builds.ToList();
            return View(builds);
        }

        public ActionResult Details(int id)
        {

            var builds = _context.Builds.Include(m => m.CPU)
                                        .Include(m => m.Memory)
                                        .Include(m => m.Motherboard)
                                        .Include(m => m.Case)
                                        .Include(m => m.PowerSupply)
                                        .Include(m => m.VideoCard)
                                        .Include(m => m.Storage)
                                        .SingleOrDefault(m => m.Id == id);

            if (builds == null)
            {
                return HttpNotFound();
            }

            return View(builds);
        }


    }
}
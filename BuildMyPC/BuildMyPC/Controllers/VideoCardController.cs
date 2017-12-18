using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BuildMyPC.Models;

namespace BuildMyPC.Controllers
{
    public class VideoCardController : Controller
    {

        private ApplicationDbContext _context;

        public VideoCardController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: VideoCard
        public ActionResult Index()
        {
            var videocard = _context.VideoCards.ToList();

            return View(videocard);
        }

        public ActionResult Details(int id)
        {

            var videocard = _context.VideoCards.Include(c => c.Brand).SingleOrDefault(c => c.Id == id);
            if (videocard == null)
                return HttpNotFound();

            return View(videocard);
        }

        public ActionResult Addvideocard(VideoCard videocard)
        {
            Session["videocard"] = videocard;

            return RedirectToAction("List", "Home");
        }
    }
}
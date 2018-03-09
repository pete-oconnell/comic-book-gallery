using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {


        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "this <strong>is</strong> the description";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: blah",
                "Colours: bing bong",
                "Letters: jabberwocky"      
            };
            return View();
        }
    }
}
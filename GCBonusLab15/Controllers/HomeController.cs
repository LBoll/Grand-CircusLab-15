using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;

using GCBonusLab15.Models;

namespace GCBonusLab15.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MovieDBEntities ORM = new MovieDBEntities();

            List<Movy> MoviesList = ORM.Movies.ToList();

            ViewBag.MoviesList = MoviesList;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
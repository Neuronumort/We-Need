using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace We_Need.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           

            return View();
        }

        public ActionResult Needs()
        {
          

            
            var nume = new List<string>();
            nume.Add("Marius");
            return View(nume);
            
        }


    }
}
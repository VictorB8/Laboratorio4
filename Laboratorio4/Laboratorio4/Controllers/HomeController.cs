using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio4.Handlers;
using Laboratorio4.Models;


namespace Laboratorio4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
            ViewBag.ValorParaTest = 1;
            return View("Contact");
        }

        public ActionResult InformacionBasica()
        {
            ViewBag.Message = "La informacion basica del planetario.";
            return View();
        }

        public ActionResult SobreNosotros()
        {
            

            return View("SobreNosotros");
        }
    }
}
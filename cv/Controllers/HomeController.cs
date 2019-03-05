using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cv.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PersonasDati()
        {
            return View();
        }

        public ActionResult DarbaPieredze()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Kontakti()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Izglitiba()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Prasmes()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Valodas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult VaditajaAplieciba()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult MotivacijasVestule()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
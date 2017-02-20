using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_Views.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            return View();
        }
        //hakkimizda
        public ActionResult about()
        {
            return View();
        }
        //iletisim
        public ActionResult contact()
        {
            return View();
        }
    }
}
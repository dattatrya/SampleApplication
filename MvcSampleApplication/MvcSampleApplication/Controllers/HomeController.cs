using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSampleApplication.Models;

namespace MvcSampleApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            Home HM = new Home();
            HM.id = 100;
            HM.name = "Dattatrya Yerande";
            ViewData["ID"] = HM.id;
            ViewData["Name"] = HM.name;
            return View(HM);
        }
    }
}

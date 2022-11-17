using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class PropertyController : Controller
    {
        // GET: Property
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetProperty()
        {
            return View();
        }

      
    }
}
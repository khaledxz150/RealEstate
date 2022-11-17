using Models.Models;
using Business.DataRetrieval;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class LookUpController : RealEstate.Controllers.BaseController.BaseController
    {
        // GET: LookUp
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lookup()
        {
            Business.DataRetrieval.RealEstateRepository realEstateRepository = new Business.DataRetrieval.RealEstateRepository();
            Models.Models.LookupViewModel lookupViewModel = new Models.Models.LookupViewModel();
            return View();
        }
    }
}
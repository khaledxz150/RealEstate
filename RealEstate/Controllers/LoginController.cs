using Business.DataRetrieval;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login (UserViewModel obj)
        {
            Business.DataRetrieval.RealEstateRepository realEstateRepository = new Business.DataRetrieval.RealEstateRepository();   
            Models.Models.UserViewModel user =realEstateRepository.Login(obj);
            Session["LangID"] = user.LangID ;
            return View(); 
        }
    }
}
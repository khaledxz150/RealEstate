
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class SignUpController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(RealEstate.Models.Models.UserViewModel obj)
        {
            Business.DataRetrieval.RealEstateRepository realEstateRepository = new Business.DataRetrieval.RealEstateRepository();
            Models.Models.UserViewModel signUpViewModel = realEstateRepository.SignUp(obj);
            return View();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace RealEstate.Controllers.BaseController
{
    public class BaseController : Controller
    {
        protected virtual RealEstate.Models.UserTicket.UserTicket CurrentUser
        {
            get
            {

                if ((System.Threading.Thread.CurrentPrincipal as RealEstate.Models.UserTicket.UserTicket) == null || !(System.Threading.Thread.CurrentPrincipal as RealEstate.Models.UserTicket.UserTicket).Identity.IsAuthenticated)
                {
                    return null;
                }
                return (RealEstate.Models.UserTicket.UserTicket)(HttpContext == null ? System.Threading.Thread.CurrentPrincipal : HttpContext.User);

            }
        }


    }
    
}
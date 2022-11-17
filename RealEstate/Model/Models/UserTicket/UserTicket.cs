using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Models.UserTicket
{
    public class UserTicket
    {
        public IIdentity Identity { get; private set; }
        public bool IsInRole(string role)
        {
            return false;
        }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public UserTicket(string email)
        {
            this.Identity = new GenericIdentity(email);
        }
    }
}

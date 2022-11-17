using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace RealEstate.Models.Models
{
    public class UserViewModel
    {

        [Key]
        [Required]
        public string UserName { get; set; }
        
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
        public int UserID { get; set; }
        [Required]
        public string UserFirstNameEng { get; set; }
        [Required]
        public string UserLastNameEng { get; set; }
        [Required]
        public string UserFirstNameAr { get; set; }
        [Required]
        public string UserLastNameAr { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public int LangID { get; set; }

        [Required]
        public int CountryID { get; set; }

        [Required]
        public int CityID { get; set; }

        [Required]
        public string AddressDescription { get; set; }

    }
}
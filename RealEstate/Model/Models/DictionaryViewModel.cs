using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealEstate.Models.Models
{
    public class DictionaryViewModel
    {
        [Key]
        public int WordID { get; set; }
    }
}
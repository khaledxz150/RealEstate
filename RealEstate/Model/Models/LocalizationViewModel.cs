using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealEstate.Models.Models
{
    public class LocalizationViewModel
    {
        [Key]
        public int DictID { get; set; }
        public int LangID { get; set; }

        public string Description { get; set; }
    }
}
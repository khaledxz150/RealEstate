using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealEstate.Models.Models
{
    public class LookupViewModel
    {
        public class LookupsViewModel {
        [Key]
        public int Id { get; set; }
        public string Desc { get; set; }
        public int CategoryID { get; set; }
        public int ParentID { get; set; }
        public int DictID { get; set; }
        public int LangID { get; set; }
        public string SparseOne { get; set; }
        public string SparseTwo { get; set; }
    }


        public class CountryLookupsKeyViewModel
        {
            [Key]
            public int Id { get; set; }
            public string Desc { get; set; }
        }

        public class CityLookupsKeyViewModel
        {
           
            public int CountryID { get; set; }
            [Key]
            public int Id { get; set; }
            public string Desc { get;set; }

        }
    }
}
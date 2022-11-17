using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealEstate.Models.Models
{
    public class PropertyViewModel
    {
        
        public int PropertyID { get; set; }
        public string PropertyName { get; set; }
        public int StatusID { get; set; }
        public int StartingPrice { get; set; }
        public string Description { get; set; }
        public string OfferType { get; set; }
        public string PropertyType { get; set; }
        public int SquareFootage { get; set; }
        public int NoOfRooms { get; set; }
        public int NoOfBathRooms { get; set; }
        public bool HasGarage { get; set; }
        public bool HasPool { get; set; }
        public bool HasBackyard { get; set; }
        public string ExtraFeature { get; set; }
    }
}
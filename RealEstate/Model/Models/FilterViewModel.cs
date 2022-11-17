using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Models.Models
{
    public class FilterViewModel
    {
        int Status { get; set; }
        int minPrice { get; set; }
        int maxPrice { get; set; }
        int minSize { get; set; }
        int maxSize { get; set; }
        int noOfBedrooms { get; set; }  
        int noOfBathrooms { get; set; }
        int hasPool { get; set; }   
        int hasGarage { get; set; } 
        int hasBackyard { get; set; }
        string extraFeature { get; set; }
        int Country { get; set; }
        int City { get; set; }
        
    }
}

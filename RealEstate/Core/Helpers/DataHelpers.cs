using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Core.Helpers
{
    public class DataHelpers
    {
        public List <string> GetDropDownList(Core.Enums.DropDownList x)
        {
            if (x == Core.Enums.DropDownList.Country)
            {
                var obj = new Business.DataRetrieval.RealEstateRepository();
                return obj.GetCountry((int)x);
            }

            //if (x == Core.Enums.DropDownList.City)
            //{
            //    var obj = new Business.DataRetrieval.RealEstateRepository();
            //    return obj.GetCity((int)x);
            //}




        }
    }
}

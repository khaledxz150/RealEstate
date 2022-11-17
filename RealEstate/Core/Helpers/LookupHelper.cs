using Business.DataRetrieval;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Core.Helpers
{
    public class LookupHelper
    {
        public List <string> GetDropDownList(int ID)
        {
            if(ID == 1)
            {
                Business.DataRetrieval.RealEstateRepository realEstateRepository = new Business.DataRetrieval.RealEstateRepository();
                return realEstateRepository.GetCountry();

            }
            if (ID == 2)
            {
                return realEstateRepository.GetCountry();

            }

        }

       
    }
}

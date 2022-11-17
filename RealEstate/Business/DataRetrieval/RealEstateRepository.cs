using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DataRetrieval
{
    public class RealEstateRepository : DataAccess
    {
        RealEstateEntities _dbContext = new RealEstateEntities();

        public RealEstate.Models.Models.UserViewModel SignUp(RealEstate.Models.Models.UserViewModel obj)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserName",obj.UserName),
                new SqlParameter("@Password",obj.Password),
                new SqlParameter("@UserFirstNameEng",obj.UserFirstNameEng),
                new SqlParameter("@UserLastNameEng",obj.UserLastNameEng),
                new SqlParameter("@UserFirstNameAr",obj.UserFirstNameAr),
                new SqlParameter("@UserLastNameAr",obj.UserLastNameAr),
                new SqlParameter("@UserEmail",obj.UserEmail),
                new SqlParameter("@PhoneNumber",obj.PhoneNumber),
                new SqlParameter("@Language",obj.LangID)
            };

            RealEstate.Models.Models.UserViewModel result = _dbContext.Database.SqlQuery<Models.Models.UserViewModel>(DataAccess.GenerateCommandText("SignUp", parameters), parameters).SingleOrDefault();
            return result;
        }

        public Models.Models.UserViewModel Login(Models.Models.UserViewModel obj)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username",obj.UserName),
                new SqlParameter("@Password", obj.Password)
            };

            Models.Models.UserViewModel result = _dbContext.Database.SqlQuery<Models.Models.UserViewModel>(DataAccess.GenerateCommandText("Login", parameters), parameters).SingleOrDefault();
            return result;
        }

        public List<Models.Models.LocalizationViewModel> DHelper(List<Models.Models.DictionaryViewModel> splitWordId, int? languageID)
        {
            var i = Business.DataRetrieval.DataAccess.ToDataTable(splitWordId);

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@LangaugeID",languageID),
                new SqlParameter("@ListWords",ToDataTable(splitWordId))
            };

            parameters[1].TypeName = "dbo.DictionaryTableType";

            List<Models.Models.LocalizationViewModel> wordsResult = _dbContext.Database.SqlQuery<Models.Models.LocalizationViewModel>(DataAccess.GenerateCommandText("DHelper", parameters), parameters).ToList();

            return wordsResult;
        }


        private SqlConnection con;

      

        public List<Models.Models.LookupViewModel.CountryLookupsKeyViewModel> GetCountry()
        {
            using (var obj = new DataAccess())
            {
              return  obj.ExcuteReader<Models.Models.LookupViewModel.CountryLookupsKeyViewModel>("GetCountry");
            };
        }

        public List <Models.Models.LookupViewModel.CityLookupsKeyViewModel> GetCity(int CountryID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
               new SqlParameter("@CountryID",CountryID)
            };
           List< Models.Models.LookupViewModel.CityLookupsKeyViewModel> result = _dbContext.Database.SqlQuery<LookupViewModel.CityLookupsKeyViewModel>(DataAccess.GenerateCommandText("GetCity", parameters), parameters).ToList();
            return result;

         }


        //public RealEstate.Models.PropertyViewModel GetProperty(int ID)
        //{
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //        new SqlParameter("@PropertyID",ID)
        //    };
        //    RealEstate.Models.PropertyViewModel result = _dbContext.Database.SqlQuery<RealEstate.Models.PropertyViewModel>(DBHelper.GenerateCommandText("GetProperty", parameters), parameters).SingleOrDefault();
        //    return result;
        //}



    }
}

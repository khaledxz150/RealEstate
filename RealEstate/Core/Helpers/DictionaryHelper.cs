using Business.DataRetrieval;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using Microsoft.AspNetCore.Http;

namespace RealEstate.Core.Helpers
{
    public class DictionaryHelper
    {

       // public int? languageID = (int?)  ?? 1;

        List<Models.Models.DictionaryViewModel> splitWordId = new List<DictionaryViewModel>();
        List<LocalizationViewModel> wordsResult;

        public void GetWordsHelper(string Words)
        { 
            var data = Words.Split(',').Select(int.Parse).ToList();

            foreach (var item in data)
            {
                splitWordId.Add(new DictionaryViewModel { WordID = item });
            }

            var obj = new DictionaryHelper();

            Business.DataRetrieval.RealEstateRepository userRepository = new Business.DataRetrieval.RealEstateRepository();
            wordsResult = userRepository.DHelper(splitWordId, languageID);
        }
        public string GetWord(int wordID)
        {
            return wordsResult.Where(x => x.DictID == wordID).SingleOrDefault().Description;
        }
    }  
}

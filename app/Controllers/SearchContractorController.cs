﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SODA;
using Newtonsoft.Json;
using app.Models;

namespace app.Controllers
{
    public class SearchContractorController
    {
        public string getAllContractorNames(string businessname) {
            string condition;
          
            if (string.IsNullOrWhiteSpace(businessname))
            {
                condition = "applicant_relationship = 'Contractor'";
            }
            else
            {
                condition = "applicant_relationship = 'Contractor AND contractors_business_name LIKE '" + businessname;
            }

            // Initialize connection to SodaClient
            var client = new SodaClient("https://data.lacity.org", 
                "8YzE0NUTN2pl4gdOcY5fAquLi",
                "dtruong8@toromail.csudh.edu",
                "Helloworld123."); 
            // SOQL string to get contractors business name
            var soql = new SoqlQuery().Select("distinct contractors_business_name")
                                       .Where(condition)
                                       .Order("contractors_business_name");
            // Apply query to table Permit Information @ data.lacity.org
            var dataset = client.GetResource<ContractorModel>("yv23-pmwf");
            // Return result to ContractorModel Object
            var results = dataset.Query<ContractorModel>(soql);
            // Convert object into json string
            string json = JsonConvert.SerializeObject(results);
            return json;
        }
    }
}
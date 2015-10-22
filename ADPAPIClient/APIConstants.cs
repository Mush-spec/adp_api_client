using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

//using ADPAPIClient;

// trial_cracked_at_third:
//   - first_third
//   - second_third
//   - final_third

// advocate_categories:
//   - QC
//   - Led junior
//   - Leading junior
//   - Junior alone

// court_types:
//    - Magistrate's Court
//    - Crown Court

// date_format: "%d/%m/%Y"
// date_time_format: "%d/%m/%Y %H:%M

namespace ADPAPIClient
{
    class APIConstants
    {
        public IList<Court> courts = new List<Court>();
        public IList<CaseType> caseTypes = new List<CaseType>();

        private static string _apiKey = ConfigurationManager.AppSettings["SecretApiKey"];

        public APIConstants()
        {
            instantiateCourts();
            instantiateCaseTypes();
        }

        public static string ApiKey
        {
            get
            {
                return _apiKey;
            }
        }

        //example of retrieving case type lookup data from API endpoint
        public void instantiateCaseTypes()
        {
            HttpClient client = new HttpClient();
            string json = client.getCaseTypes();

            JArray caseTypeArray = JArray.Parse(json);
            IList<JToken> tokens = caseTypeArray.Children().ToList();

            foreach (JToken token in tokens)
            {
                CaseType caseType = JsonConvert.DeserializeObject<CaseType>(token.ToString());
                caseTypes.Add(caseType);
            }
        }

        //example of retrieving court lookup data from API endpoint
        public void instantiateCourts()
        {
            HttpClient client = new HttpClient();
            string json = client.getCourts();

            JArray courtArray = JArray.Parse(json);
            IList<JToken> tokens = courtArray.Children().ToList();

            foreach (JToken token in tokens)
            {
                Court court = JsonConvert.DeserializeObject<Court>(token.ToString());
                courts.Add(court);
            }
        }

        public NamedEntity[] advocateCategories = new NamedEntity[]
        {
            new NamedEntity(0,"", "-Select advocate category-"),
            new NamedEntity(1,"QC","QC"),
            new NamedEntity(2,"Led junior","Led junior"),
            new NamedEntity(3,"Leading junior","Leading junior"),
            new NamedEntity(4,"Junior alone","Junior alone")
        };

        //not required
        public NamedEntity[] trialCrackedAtThirds = new NamedEntity[]
        {
            new NamedEntity(0,"", "-Select cracked third category-"),
            new NamedEntity(1,"first_third","First Third"),
            new NamedEntity(2,"second_third","Second Third"),
            new NamedEntity(3,"final_third","Final Third"),
        };

    }

   

}

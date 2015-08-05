using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using ADPAPIClient;

// case_types:
//   - appeal_against_conviction
//   - appeal_against_sentence
//   - breach_of_crown_court_order
//   - commital_for_sentence
//   - contempt
//   - cracked_trial
//   - cracked_before_retrial
//   - discontinuance
//   - elected_cases_not_proceeded
//   - fixed_fee
//   - guilty_plea
//   - retrial
//   - trial

// trial_cracked_at_third:
//   - first_third
//   - second_third
//   - final_third

// advocate_categories:
//   - QC
//   - Led junior
//   - Leading junior
//   - Junior alone

// prosecuting_authorities:
//   - cps

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

        public APIConstants()
        {
            instantiateCourts();
        }

        //example of retrieving lookup data from API endpoint
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

        public NamedEntity[] caseTypes = new NamedEntity[]
        {
            new NamedEntity(0,"", "--- Select case type ---"),
            new NamedEntity(1,"appeal_against_conviction", "Appeal against conviction"),
            new NamedEntity(2,"appeal_against_sentence", "Appeal against sentence"),
            new NamedEntity(3,",breach_of_crown_court_order", "Breach of Crown Court order"),
            new NamedEntity(4,"commital_for_sentence", "Commital for Sentence"),
            new NamedEntity(5,"contempt", "Contempt"),
            new NamedEntity(6,"cracked_trial", "Cracked trial"),
            new NamedEntity(7,"cracked_before_retrial", "Cracked before retrial"),
            new NamedEntity(8,"discontinuance", "Discontinuance"),
            new NamedEntity(9,"fixed_fee", "Fixed Fee"),
            new NamedEntity(10,"elected_cases_not_proceeded", "Elected cases not proceeded"),
            new NamedEntity(11,"guilty_plea", "Guilty Plea"),
            new NamedEntity(12,"retrial", "Retrial"),
            new NamedEntity(13,"trial", "Trial"),

        };

        public NamedEntity[] advocateCategories = new NamedEntity[]
        {
            new NamedEntity(0,"", "--- Select advocate category ---"),
            new NamedEntity(1,"QC","QC"),
            new NamedEntity(2,"Led junior","Led junior"),
            new NamedEntity(3,"Leading junior","Leading junior"),
            new NamedEntity(4,"Junior alone","Junior alone")
        };

        //not required
        public NamedEntity[] trialCrackedAtThirds = new NamedEntity[]
        {
            new NamedEntity(0,"", "--- Select cracked third category ---"),
            new NamedEntity(1,"first_third","First Third"),
            new NamedEntity(2,"second_third","Second Third"),
            new NamedEntity(3,"final_third","Final Third"),
        };

    }

   

}

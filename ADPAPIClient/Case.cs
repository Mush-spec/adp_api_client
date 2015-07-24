using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ADPAPIClient
{
    class Case
    {
        public string advocateEmail { private get; set; }
        public string caseNumber { private get; set; }
        public string caseTypeId { private get; set; }
        public string cmsNumber { private get; set; }
        public string indictmentNumber { private get; set; }
        public string advocateCategory { private get; set; }
        public string prosecutingAuthority { private get; set; }
        public string additionalInformation { private get; set; }

        public decimal estimatedTrialLength { private get; set; }
        public decimal actualTrialLength { private get; set; }
        
        public bool applyVat { private get; set; }

        public DateTime trialStartDate { private get; set; }
        public DateTime endTrialDate { private get; set; }
        public DateTime trialFixedNoticeDate { private get; set; }
        public DateTime trialFixedDate { private get; set; }
        public DateTime trialCrackedDate { private get; set; }
        public DateTime trialCrackedAtThirdDate { private get; set; }



    public Case()
        {
            // Console.WriteLine("Case instantiated");
        }

        
        public string toJson()
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>();

            // mandatory fields
            myDict.Add("advocate_email", this.advocateEmail);
            myDict.Add("case_number", this.caseNumber);
            myDict.Add("case_type", this.caseTypeId);
            myDict.Add("indictment_number", this.indictmentNumber);
            myDict.Add("first_day_of_trial", convertDate(this.trialStartDate));
            myDict.Add("estimated_trial_length", Convert.ToString(this.estimatedTrialLength));
            myDict.Add("actual_trial_length", Convert.ToString(this.actualTrialLength));
            myDict.Add("trial_concluded_at", convertDate(this.endTrialDate));
            myDict.Add("advocate_category", this.advocateCategory);

            // optional fields
            myDict.Add("cms_number", this.cmsNumber);
            myDict.Add("additional information", this.additionalInformation);
            myDict.Add("apply_vat", Convert.ToString(this.applyVat));
            myDict.Add("prosecuting_authority", this.prosecutingAuthority);
            myDict.Add("trial_fixed_notice_at", convertDate(this.trialFixedNoticeDate));
            myDict.Add("trial_fixed_at", convertDate(this.trialFixedDate));
            myDict.Add("trial_cracked_at", convertDate(this.trialCrackedDate));
            myDict.Add("trial_cracked_at_third", convertDate(this.trialCrackedAtThirdDate));

            return JsonConvert.SerializeObject(myDict);
        }


        private string convertDate(DateTime date)
        {
            string result = "";
            if (date != new DateTime())
            {
                result = Convert.ToString(date);
            }
            return result;
        }
       
    }
}

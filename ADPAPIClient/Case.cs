using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Windows.Forms;

namespace ADPAPIClient
{
    class Case
    {
        public string advocateEmail { private get; set; }
        public string caseNumber { private get; set; }
        public string caseType { private get; set; }
        public string courtId { private get; set; }
        public string offenceId { private get; set; }
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
        public DateTime trialFixedNoticeAt { private get; set; }
        public DateTime trialFixedAt { private get; set; }
        public DateTime trialCrackedAt { private get; set; }
        public string trialCrackedAtThird { private get; set; }

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
            myDict.Add("case_type", this.caseType);
            myDict.Add("court_id", this.courtId);
            myDict.Add("offence_id", "36");
            myDict.Add("prosecuting_authority", this.prosecutingAuthority);

            myDict.Add("indictment_number", this.indictmentNumber);
            myDict.Add("first_day_of_trial", convertDate(this.trialStartDate));
            myDict.Add("estimated_trial_length", Convert.ToString(this.estimatedTrialLength));
            myDict.Add("actual_trial_length", Convert.ToString(this.actualTrialLength));
            myDict.Add("trial_concluded_at", convertDate(this.endTrialDate));
            myDict.Add("advocate_category", this.advocateCategory);

            // optional fields
            // - only send them if they have a value
            if (!String.IsNullOrEmpty(this.cmsNumber))              myDict.Add("cms_number", this.cmsNumber);
            if (!String.IsNullOrEmpty(this.additionalInformation))  myDict.Add("additional_information", this.additionalInformation);
            if (!String.IsNullOrEmpty(this.applyVat.ToString()))    myDict.Add("apply_vat", Convert.ToString(this.applyVat));
           
            if (this.trialFixedNoticeAt != new DateTime())          myDict.Add("trial_fixed_notice_at", convertDate(this.trialFixedNoticeAt));
            if (this.trialFixedAt != new DateTime())                myDict.Add("trial_fixed_at", convertDate(this.trialFixedAt));
            if(this.trialCrackedAt != new DateTime())               myDict.Add("trial_cracked_at", convertDate(this.trialCrackedAt));
            if (!String.IsNullOrEmpty(this.trialCrackedAtThird))    myDict.Add("trial_cracked_at_third", this.trialCrackedAtThird);

            //don't think the IsoDateTimeConverter has any impact here
            return JsonConvert.SerializeObject(myDict, new IsoDateTimeConverter());
        }

        private string convertDate(DateTime date)
        {
            string result = "";
            if (date != new DateTime())
            {
                //see MSDN Round-trip ("o") format specified
                result = date.ToString("o");
            }
            return result;
        }

    }
}

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
        public DateTime trialStartDate { private get; set; }


        public Case()
        {
            Console.WriteLine("Case instantiated");
        }

        /*
        public Case (string advocateEmail, string caseNumber, string caseTypeId, string cmsNumber)
        {
            this.advocateEmail = advocateEmail;
            this.caseNumber = caseNumber;
            this.caseTypeId = caseTypeId;
            this.cmsNumber = cmsNumber;
        }
        */

        public string toJson()
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add("advocate_email", this.advocateEmail);
            myDict.Add("case_number", this.caseNumber);
            myDict.Add("case_type", this.caseTypeId);
            myDict.Add("cms_number", this.cmsNumber);
            myDict.Add("trial_start_date", Convert.ToString(this.trialStartDate));

            return JsonConvert.SerializeObject(myDict);

        }
       
    }
}

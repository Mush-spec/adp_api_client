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
        public string advocateEmail;
        public string caseNumber;
        public string caseTypeId;
        public string cmsNumber;

        public Case (string advocateEmail, string caseNumber, string caseTypeId, string cmsNumber)
        {
            this.advocateEmail = advocateEmail;
            this.caseNumber = caseNumber;
            this.caseTypeId = caseTypeId;
            this.cmsNumber = cmsNumber;
        }


        public string toJson()
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add("advocate_email", this.advocateEmail);
            myDict.Add("case_number", this.caseNumber);
            myDict.Add("case_type", this.caseTypeId);
            myDict.Add("cms_number", this.cmsNumber);

            return JsonConvert.SerializeObject(myDict);

        }
       
    }
}

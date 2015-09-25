using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ADPAPIClient
{
    class CaseType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsFixedFee { get; set; }
        public bool RequiresCrackedDates { get; set; }
        public bool RequiresTrialDates { get; set; }
        public bool RequiresMaatReference{ get; set; }

        public CaseType()
        {



        }

    }
}

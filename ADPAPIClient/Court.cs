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
    class Court
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Courtype { get; set; }

        public Court()
        {
            


        }
        
    }
}

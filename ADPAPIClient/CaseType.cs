using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPAPIClient
{
    class CaseType
    {
        public int Id { get; set; }
        public string Description { get; set; }


        public CaseType(int id, string description)
        {
            this.Id = id;
            this.Description = description;
        }
    }
}

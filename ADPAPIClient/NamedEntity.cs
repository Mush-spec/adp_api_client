using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPAPIClient
{
    class NamedEntity
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

        public NamedEntity(int id,String value, string description)
        {
            this.Id = id;
            this.Value = value;
            this.Description = description;
        }

    }
}

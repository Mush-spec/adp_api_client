using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPAPIClient
{
    class APIConstants
    {
        public NamedEntity[] caseTypes = new NamedEntity[]
        {
            new NamedEntity(0, "--- Select case type ---"),
            new NamedEntity(1, "Appeal against conviction"),
            new NamedEntity(2, "Appeal against sentence"),
            new NamedEntity(3, "Breach of Crown Court order"),
            new NamedEntity(3, "Commital for Sentence"),
            new NamedEntity(3, "Contempt"),
            new NamedEntity(3, "Cracked trial"),
            new NamedEntity(3, "Cracked before retrial"),
            new NamedEntity(3, "Discontinuance"),
            new NamedEntity(3, "Elected cases not proceeded"),
            new NamedEntity(3, "Guilty Plea"),
            new NamedEntity(3, "Retrial"),
            new NamedEntity(3, "Trial"),

        };


        public NamedEntity[] advocateCategories = new NamedEntity[]
        {
            new NamedEntity(0, "--- Select advocate category ---"),
            new NamedEntity(1, "QC"),
            new NamedEntity(1, "Led junior"),
            new NamedEntity(1, "Leading junior"),
            new NamedEntity(1, "Junior alone")
        };
     }
}

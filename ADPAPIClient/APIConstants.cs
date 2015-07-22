using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPAPIClient
{
    class APIConstants
    {
        public CaseType[] caseTypes = new CaseType[]
        {
            new CaseType(0, "--- Select case type ---"),
            new CaseType(1, "Appeal against conviction"),
            new CaseType(2, "Appeal against sentence"),
            new CaseType(3, "Breach of Crown Court order"),
            new CaseType(3, "Commital for Sentence"),
            new CaseType(3, "Contempt"),
            new CaseType(3, "Cracked trial"),
            new CaseType(3, "Cracked before retrial"),
            new CaseType(3, "Discontinuance"),
            new CaseType(3, "Elected cases not proceeded"),
            new CaseType(3, "Guilty Plea"),
            new CaseType(3, "Retrial"),
            new CaseType(3, "Trial"),

        };
    }
}

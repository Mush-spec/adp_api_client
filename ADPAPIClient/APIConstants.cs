using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// case_types:
//   - appeal_against_conviction
//   - appeal_against_sentence
//   - breach_of_crown_court_order
//   - commital_for_sentence
//   - contempt
//   - cracked_trial
//   - cracked_before_retrial
//   - discontinuance
//   - elected_cases_not_proceeded
//   - fixed_fee
//   - guilty_plea
//   - retrial
//   - trial

// trial_cracked_at_third:
//   - first_third
//   - second_third
//   - final_third

// advocate_categories:
//   - QC
//   - Led junior
//   - Leading junior
//   - Junior alone

// prosecuting_authorities:
//   - cps

// court_types:
//    - Magistrate's Court
//    - Crown Court

// date_format: "%d/%m/%Y"
// date_time_format: "%d/%m/%Y %H:%M

namespace ADPAPIClient
{
    //class DB
    //{
    //    private static readonly DB instance = new DB();
    //    public static DB Instance { get { return instance; } }

    //    static DB() { }
    //    private DB()
    //    {
    //        StaticData = new System.Data.DataSet();
    //    }

    //    private static System.Data.DataSet StaticData;

    //    public System.Data.DataTable GetCaseTypeTable()
    //    {
    //        // check if the table has been created
    //        if (StaticData.Tables["case_types"] == null)
    //        {
    //            // build table (or retrieve from database)
    //            System.Data.DataTable table = new System.Data.DataTable();
    //            table.TableName = "case_types";
    //            table.Columns.Add("id", typeof(int));
    //            table.Columns.Add("value", typeof(string));
    //            table.Columns.Add("description", typeof(string));

    //            table.Rows.Add(1, "appeal_against_conviction", "Appeal against conviction");
    //            table.Rows.Add(1, "appeal_against_sentence", "Appeal against sentence");
    //            table.Rows.Add(1, "breach_of_crown_court_order", "Breach of crown court order");

    //            StaticData.Tables.Add(table.Copy());

    //        }
    //        return StaticData.Tables["case_types"];
    //    }
    //}

    class APIConstants
    {
        public NamedEntity[] caseTypes = new NamedEntity[]
        {
            new NamedEntity(0,"", "--- Select case type ---"),
            new NamedEntity(1,"appeal_against_conviction", "Appeal against conviction"),
            new NamedEntity(2,"appeal_against_sentence", "Appeal against sentence"),
            new NamedEntity(3,",breach_pf_crown_court_order", "Breach of Crown Court order"),
            new NamedEntity(4,"commital_for_sentence", "Commital for Sentence"),
            new NamedEntity(5,"contempt", "Contempt"),
            new NamedEntity(6,"cracked_trial", "Cracked trial"),
            new NamedEntity(7,"cracked_before_retrial", "Cracked before retrial"),
            new NamedEntity(8,"discontinuance", "Discontinuance"),
            new NamedEntity(9,"fixed_fee", "Fixed Fee"),
            new NamedEntity(10,"elected_cases_not_proceeded", "Elected cases not proceeded"),
            new NamedEntity(11,"guilty_plea", "Guilty Plea"),
            new NamedEntity(12,"retrial", "Retrial"),
            new NamedEntity(13,"trial", "Trial"),

        };


    public NamedEntity[] advocateCategories = new NamedEntity[]
        {
            new NamedEntity(0,"", "--- Select advocate category ---"),
            new NamedEntity(1,"QC","QC"),
            new NamedEntity(2,"Led junior","Led junior"),
            new NamedEntity(3,"Leading junior","Leading junior"),
            new NamedEntity(4,"Junior alone","Junior alone")
        };
     }
}

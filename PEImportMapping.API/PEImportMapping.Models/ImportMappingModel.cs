using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEImportMapping.API.Models
{
    public class ImportMappingModel
    {

        public string HeaderEventType { get; set; }
        public string UltimateParentAccountName  { get; set; }
        public string LegalName  { get; set; }
        public string AccountName  { get; set; }
        public string EntitlementCatalog { get; set; }
         public string TenantRecipe { get; set; }

        public string subscriptionNumber { get; set; }
        public string subscriptionAccountNumber { get; set; }
        public int version { get; set; }
        public string contractEffectiveDate { get; set; }
        public string status { get; set; }
        public string rateplanId { get; set; }
    }


    public class ZouraPayloadModel
    {

        public string Header_Event_Type { get; set; }
        public string Ultimate_Parent_Account_Name { get; set; }
        public string Legal_Name { get; set; }
        public string Account_Name { get; set; }

        public Subscription[] subscription { get; set; }

    }

    public class Subscription
    {
        public string Subscription_Account_Number { get; set; }
        public string subscriptionNumber { get; set; }
        public int version { get; set; }
        public string Contract_Effective_Date { get; set; }
        public string status { get; set; }

        public RatePlans rateplans { get; set; }
    }

    public class RatePlans
    {
        public string id { get; set; }
    }
}

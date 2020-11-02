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
    }


    public class ZouraPayloadModel
    {

        public string Header_Event_Type { get; set; }
        public string Ultimate_Parent_Account_Name { get; set; }
        public string Legal_Name { get; set; }
        public string Account_Name { get; set; }

    }
}

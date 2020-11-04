using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEImportMapping.API.Models;

namespace PEImportMapping.API.PEImportMapping.Buisness
{
    public class ImportMapping: IImportMapping
    {
       
        public ImportMappingModel ForgeModelobj;

     

        public Object PEImportMapping(ZouraPayloadModel data)
        {

            ForgeModelobj = new ImportMappingModel()
            {
                HeaderEventType = data.Header_Event_Type,
                UltimateParentAccountName = data.Ultimate_Parent_Account_Name,
                LegalName = data.Legal_Name,
                AccountName = data.Account_Name,
                subscriptionNumber = data.subscription[0].subscriptionNumber,
                subscriptionAccountNumber = data.subscription[0].Subscription_Account_Number,
                EntitlementCatalog = "EntitlementCatalog",
                TenantRecipe = "TenantRecipe"
            };



            return ForgeModelobj;

        }

        
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEImportMapping.API.Models;

namespace PEImportMapping.API.PEImportMapping.Buisness
{
    public class ImportMapping: IImportMapping
    {
       
        public ImportMappingModel ForgeModelobj;

     

        public Object PEImportMapping(zourapayloadModel data)
        {
            
            ForgeModelobj = new ImportMappingModel()
            {
                HeaderEventType = data.Header_Event_Type ,
                UltimateParentAccountName = data.Ultimate_Parent_Account_Name,
                LegalName = data.Legal_Name,
                AccountName = data.Account_Name,
                EntentitlementCatelog = "EntentitlementCatelog",
                TenantRecipe = "TenantRecipe"
            };



            return ForgeModelobj;

        }

        
    }
}

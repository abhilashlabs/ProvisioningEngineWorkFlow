using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEImportMapping.API.PEImportMapping.Buisness
{
    public class ImportMapping:IImportMapping
    {
        public Object ImportFile()
        {
            var myJsonString = System.IO.File.ReadAllText("ZouraPayloads/CreateSubscription.json");
            var myJObject = JObject.Parse(myJsonString);
            ForgeModelobj = new ForgeModel();
            return myJObject;

        }
    }
}

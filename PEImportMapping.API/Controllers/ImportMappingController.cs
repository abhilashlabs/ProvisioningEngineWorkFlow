using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;


namespace PEImportMapping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportMappingController : ControllerBase
    {
       [HttpPost]
        public Object ImportFile()
        {
            var myJsonString = System.IO.File.ReadAllText("ZouraPayloads/CreateSubscription.json");
            var myJObject = JObject.Parse(myJsonString);

            return myJObject;

        }

    }
}

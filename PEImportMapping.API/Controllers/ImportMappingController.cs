using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PEImportMapping.API.PEImportMapping.Buisness;
using PEImportMapping.API.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace PEImportMapping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class ImportMappingController : ControllerBase
    {
     
        private readonly ImportMapping _importmapping;
        private readonly String apiBaseUrl = "https://localhost:44348/api/PECore/";
        public ImportMappingController(ImportMapping importmapping)
        {
            _importmapping = importmapping;
        }

        [HttpPost]
        public   Object Post([FromBody] zourapayloadModel data)
        {
            var payload = _importmapping.PEImportMapping( data);
           
            //using (HttpClient client = new HttpClient())
            //{
            //    StringContent content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            //    string endpoint = apiBaseUrl;

            //    using (var Response =  client.PostAsync(endpoint, content))
            //    {
            //        payload = Response;
                 
            //    }
            //}
                return payload;
        }


    }
}

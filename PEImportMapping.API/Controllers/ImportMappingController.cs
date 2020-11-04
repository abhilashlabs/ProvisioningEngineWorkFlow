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
using PEImportMapping.API.PEImportMapping.Business;

namespace PEImportMapping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class ImportMappingController : ControllerBase
    {
     
        private readonly ImportMapping _importMapping;
        private readonly String apiBaseUrl = "https://localhost:44348/api/PECore/";
        private ILog logger;
        public ImportMappingController(ImportMapping importMapping, ILog logger)
        {
            _importMapping = importMapping;
            this.logger = logger;
        }
        
       
        //// GET api/values  
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    logger.Information("Information is logged");
        //    logger.Warning("Warning is logged");
        //    logger.Debug("Debug log is logged");
        //    logger.Error("Error is logged");

        //    return new string[] { "value1", "value2" };
        //}

        [HttpPost]
        public   IActionResult Post([FromBody] ZouraPayloadModel data)
        {
            logger.Information("-------------------");
            logger.Information("Zuora Payload -->");
            logger.Information("-------------------");
            logger.Information(JsonConvert.SerializeObject(data).ToString());
            logger.Information("-------------------");
            logger.Information("Import Mapping Api is Logged");
            logger.Information("Converted Zuora Payload to Forge understandable format");
            logger.Information("Appended Entitlement catalog to Zuora payload");
            logger.Information("Appended Tenant Recipe to Zuora payload");
            
            try
            {
               var payload = _importMapping.PEImportMapping(data);
                using (HttpClient client = new HttpClient())
                {
                    logger.Information("Calling PE Core with converted payload");
                    StringContent content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                    string endpoint = apiBaseUrl;

                    //using (var Response = client.PostAsync(endpoint, content))
                    //{
                    //    payload = Response;

                    //}
                    logger.Information("Mapped Payload -->");
                    logger.Information("-------------------");
                    logger.Information(JsonConvert.SerializeObject(payload).ToString());
                    logger.Information("-------------------");
                    var response = client.PostAsync(endpoint, content);
                    response.Wait();
                    if (response.IsCompleted)
                    {
                        
                        return Ok(payload);
                    }
                    else
                        return BadRequest("API is not called");
                }
                
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
                return BadRequest(ex.Message);
            }
            
            //return payload;

        }


    }
}

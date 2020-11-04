using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PEImportMapping.API.PEImportMapping.Business;

namespace PECore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PECoreController : ControllerBase
    {
        private readonly String apiBaseUrl = "https://localhost:44317/api/ExportMapping/";
        private ILog logger;
        public PECoreController(ILog logger)
        {
            this.logger = logger;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Object data)
        {
            logger.Information("Provisioning Engine Core Api is called");
            logger.Information(data.ToString());
           
            using (HttpClient client = new HttpClient())
            {
                logger.Information("Calling Provisioning Engine Export Mapping with the mapped data");
                StringContent content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                string endpoint = apiBaseUrl;
               
                var response = client.PostAsync(endpoint, content);
                response.Wait();
                if (response.IsCompleted)
                {
                    return Ok(response.Result);
                }
                return Ok(data);
            }
            
        }
    }
}

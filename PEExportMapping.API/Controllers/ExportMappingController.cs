using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PEImportMapping.API.PEImportMapping.Business;

namespace PEExportMapping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportMappingController : ControllerBase
    {
        private ILog logger;
        public ExportMappingController(ILog logger)
        {
            this.logger = logger;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Object data)
        {
            logger.Information("PE Export Mapping API is called");

            return Ok("success");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PECore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PECoreController : ControllerBase
    {

        [HttpPost]
        public Object Post([FromBody] Object data)
        {

           // List<string> str = new List<string>();
           // str.Add("received");
            return data;
        }
    }
}

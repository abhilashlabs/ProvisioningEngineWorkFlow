using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEImportMapping.API.Models;

namespace PEImportMapping.API.PEImportMapping.Buisness
{
    interface IImportMapping
    {
        object PEImportMapping(ZouraPayloadModel data);
    }
}

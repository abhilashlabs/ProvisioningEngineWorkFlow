using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEImportMapping.API.PEImportMapping.Business
{
    public interface ILog
    {
        void Information(string message);
        void Error(string message);
        void Debug(string message);
        void Warning(string message);
    }
}

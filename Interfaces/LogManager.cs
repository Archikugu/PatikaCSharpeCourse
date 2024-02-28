using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class LogManager : ILogger
    {
        public ILogger _Logger;
        public LogManager(ILogger logger)
        {
            _Logger = logger;

        }
        public void WriteLog()
        {
            _Logger.WriteLog();
        }
    }
}

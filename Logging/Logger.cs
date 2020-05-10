using System;
using System.Collections.Generic;
using System.Text;

namespace Logging
{
    public abstract class Logger
    {
        public abstract void WriteLog(LogLevel logLevel, string errorMessage, string additionalInfo = null);
    }
}

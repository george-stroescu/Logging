using System;
using System.Collections.Generic;
using System.Text;

namespace Logging
{
    class ConsoleLogger : Logger
    {
        public override void WriteLog(LogLevel logLevel, string errorMessage, string additionalInfo = null)
        {
            Console.WriteLine($"{logLevel}: {errorMessage}");

            if(!String.IsNullOrWhiteSpace(additionalInfo))
            {
                Console.WriteLine($"{additionalInfo}");
            }
        }
    }
}

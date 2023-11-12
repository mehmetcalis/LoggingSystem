using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSystem
{
    class Program
    {
        static void Main()
        {           
            var loggerFactory = new LoggerFactory();

            var consoleLogger = loggerFactory.CreateLogger(LoggerType.Console);
            consoleLogger.Log("Console log message.");

            var fileLogger = loggerFactory.CreateLogger(LoggerType.File, "log.txt");
            fileLogger.Log("File log message.");

            var inMemoryLogger = loggerFactory.CreateLogger(LoggerType.InMemory, logStore: new List<string>());
            inMemoryLogger.Log("In-memory log message.");
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSystem
{
    public class LoggerFactory
    {
        public ILogger CreateLogger(LoggerType type, string filePath = null, List<string> logStore = null)
        {
            switch (type)
            {
                case LoggerType.Console:
                    return new ConsoleLogger();
                case LoggerType.File:
                    return new FileLogger(filePath);
                case LoggerType.InMemory:
                    return new InMemoryLogger(logStore);
                default:
                    throw new NotSupportedException($"Logger type {type} not supported.");
            }
        }
    }
}

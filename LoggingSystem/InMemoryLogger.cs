using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSystem
{
    public class InMemoryLogger : ILogger
    {
        private readonly List<string> logStore;

        public InMemoryLogger(List<string> logStore)
        {
            this.logStore = logStore ?? throw new ArgumentNullException(nameof(logStore));
        }

        public void Log(string message)
        {
            logStore.Add($"[In-Memory] {message}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_14_2
{
    internal class LogEntry
    {
        private DateTime timestamp;
        private string message;

        public LogEntry(DateTime timestamp, string message)
        {
            this.timestamp = timestamp;
            this.message = message;
        }
        public override string ToString()
        {
            return $"{timestamp}: {message}";
        }
    }
}

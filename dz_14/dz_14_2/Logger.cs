using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace dz_14_2
{
    internal static class Logger 
    {
        private static List<DateTime> stamps = new List<DateTime>();
        private static List<string> mess = new List<string>();
        public static void AddLog(string message) 
        {
            stamps.Add(DateTime.Now);
            mess.Add(message);
        }
        public static string GetLogs()
        {
            List<string> logEntries = new List<string>();
            for (int i = 0; i < stamps.Count; i++)
            {
                logEntries.Add($"{stamps[i]}: {mess[i]}");
            }
            return string.Join("\n", logEntries);
        }
    }
}

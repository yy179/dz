namespace dz_14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogEntry logstart = new LogEntry(DateTime.Now,"Unknown request");
            Logger.AddLog("Bad connection");
            Logger.AddLog("Disconnected");
            Console.WriteLine($"{logstart}\n{Logger.GetLogs()}");
        }
    }
}
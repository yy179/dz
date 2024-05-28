namespace dz_14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PluginManager manager = new PluginManager();
            IPlugin greeting = new GreetingPlugin();
            IPlugin calc = new CalculatorPlugin(2,3);
            manager.LoadPlugin(greeting);
            manager.LoadPlugin(calc);
            manager.starter();
        }
    }
}
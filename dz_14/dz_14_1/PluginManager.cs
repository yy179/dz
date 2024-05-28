using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_14_1
{
    internal class PluginManager
    {
        private List<IPlugin> plugins = new List<IPlugin>();
        public void LoadPlugin(IPlugin plugin)
        {
            plugins.Add(plugin);
        }
        public void starter() 
        {
            foreach(var plugin in plugins) {plugin.Execute();}
        }
    }
}
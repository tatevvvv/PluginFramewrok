using PluginFramewrok.Plugins;

namespace PluginFramewrok.Abstractions
{
    public class PluginCatalog : IPluginCatalog
    {
        private readonly List<IEffectPlugin> _plugins;

        public PluginCatalog()
        {
            _plugins = new List<IEffectPlugin>();
        }

        public IReadOnlyList<IEffectPlugin> Plugins => _plugins;

        public void Register(IEffectPlugin plugin)
        {
            _plugins.Add(plugin);
        }

        public IEffectPlugin? GetPluginByName(string name)
        {
            return _plugins.FirstOrDefault(p => p.Name == name);
        }
    }
}

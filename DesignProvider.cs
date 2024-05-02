using PluginFramewrok.Abstractions;
using PluginFramewrok.Effects;

namespace PluginFramewrok
{
    internal class DesignProvider : IDesignProvider
    {
        private readonly IPluginCatalog _pluginRegister;

        public DesignProvider(IPluginCatalog pluginRegister)
        {
            _pluginRegister = pluginRegister;
        }

        public void Apply(ImageModel imageModel, Dictionary<string, object> parameters, IEnumerable<string> effects)
        {
            // for each effect name load correspondign IEffect from plugin register and apply it by corresponding parameters

            foreach (var effect in effects)
            {
                var plugin = _pluginRegister.GetPluginByName(effect);
                plugin.Apply(imageModel);
            }
        }

        public List<string> GetAvailableEffectNames()
        {
            return _pluginRegister.Plugins.Select(p => p.Name).ToList();
        }
    }
}

using PluginFramewrok.Plugins;

namespace PluginFramewrok.Abstractions
{
    public interface IPluginCatalog
    {
        void Register(IEffectPlugin plugin);

        IReadOnlyList<IEffectPlugin> Plugins { get; }

        IEffectPlugin? GetPluginByName(string name);
    }
}

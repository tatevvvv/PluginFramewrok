namespace PluginFramewrok.Plugins
{
    public interface IEffectPlugin
    {
        string Name { get; }

        void Apply(ImageModel imageModel);
    }
}

namespace PluginFramewrok
{
    public interface IDesignProvider
    {
        List<string> GetAvailableEffectNames();

        void Apply(ImageModel imageModel, Dictionary<string, object> parameters, IEnumerable<string> effects);
    }
}

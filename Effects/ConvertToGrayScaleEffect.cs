using PluginFramewrok.Plugins;

namespace PluginFramewrok.Effects
{
    internal class ConvertToGrayScaleEffect : IEffectPlugin
    {
        public string Name => "Convert to Gray scale";

        public void Apply(ImageModel imageModel)
        {
            // apply effect one on image
        }
    }
}

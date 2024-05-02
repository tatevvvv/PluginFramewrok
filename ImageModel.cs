namespace PluginFramewrok
{
    // I will assume that this is the model that needs to be passed as image to work with.
    public sealed class ImageModel(byte[] data)
    {
        public byte[] Data { get; init; } = data;
    }
}

namespace PluginFramewrok
{
    public sealed class GlobalParameters
    {
        public Dictionary<string, object> Parameters { get; set; }

        public GlobalParameters()
        {
            Parameters = new Dictionary<string, object>();
        }

        public void AddParameter(string key, object value)
        {
            Parameters[key] = value;
        }

        public object GetParameter<T>(string key)
        {
            if (Parameters.ContainsKey(key))
            {
                return Parameters[key];
            }

            return default;
        }
    }

}

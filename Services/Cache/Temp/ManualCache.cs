namespace BlazorEmployeeManagement.Services.Cache.Temp
{
    public class ManualCache : ICache
    {

        private readonly Dictionary<string, object> _cache = new();

        public T? Get<T>(string key)
        {
            if (_cache.TryGetValue(key, out var value))
            {
                return (T)value;
            }

            return default;
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }

        public void Set<T>(string key, T value)
        {
            _cache[key] = value!;
        }
    }
}

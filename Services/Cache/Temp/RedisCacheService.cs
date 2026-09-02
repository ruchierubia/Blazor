
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace BlazorEmployeeManagement.Services.Cache.Temp
{
    public class RedisCacheService : ICache
    {
        private readonly IDistributedCache _cache;

        public RedisCacheService(IDistributedCache cache)
        {
            _cache = cache;
        }

        public T? Get<T>(string key)
        {
            var json = _cache.GetString(key);

            if (json == null)
                return default;

            return JsonSerializer.Deserialize<T>(json);
        }

        public void Set<T>(string key, T value)
        {
            var json = JsonSerializer.Serialize(value);

            _cache.SetString(key, json);
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }
    }
}

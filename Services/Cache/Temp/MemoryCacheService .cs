using Microsoft.Extensions.Caching.Memory;

namespace BlazorEmployeeManagement.Services.Cache.Temp
{
    public class MemoryCacheService : ICache
    {
        private readonly IMemoryCache _cache;

        public MemoryCacheService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public T? Get<T>(string key)
        {
            return _cache.Get<T>(key);
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }

        public void Set<T>(string key, T value)
        {
            _cache.Set(key, value);
        }
    }
}

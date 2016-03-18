using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace MusicStore.Extensions
{
    // Summary:
    //     Specifying a cacheTimeout in config of 0 or less indicates the memory cache is not to be used at all.
    //     Wrapper methods for the IMemoryCache service that stubs out the use of the cache if the cache timeout is 0 or less.
    
    public static class MemoryCacheExtensions
    {
        public static void RemoveExt(this IMemoryCache cache, object cacheKey, int cacheTimeout)
        {
            if (cacheTimeout > 0)
                cache.Remove(cacheKey);
        }

        public static object SetExt<T>(this IMemoryCache cache, object key, T value, MemoryCacheEntryOptions options, int cacheTimeout)
        {
            if (cacheTimeout > 0)
            {
                return cache.Set(key, value, options);
            }
            return value;
        }

        public static bool TryGetValueExt<T>(this IMemoryCache cache, object key, out T value, int cacheTimeout)
        {
            if (cacheTimeout > 0)
            {
                return cache.TryGetValue(key, out value);
            }
            value = default(T);
            return false;
        }
    }
}

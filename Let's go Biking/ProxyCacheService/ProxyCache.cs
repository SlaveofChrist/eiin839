using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace ProxyCacheService
{
    class ProxyCache<T>
    {
        private DateTimeOffset dt_default;
        private ObjectCache cache = MemoryCache.Default;
        public ProxyCache()
        {
            dt_default = ObjectCache.InfiniteAbsoluteExpiration;
        }


        public T Get(string CacheItemName)
        {
            if (!cache.Contains(CacheItemName) || cache.Get(CacheItemName) == null)
            {
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = dt_default;
                T elementT = (T) Activator.CreateInstance(typeof(T), CacheItemName);
                cache.Add(CacheItemName, elementT, cacheItemPolicy);
                return elementT;
            }
            return default(T);
        }

        public T Get(string CacheItemName, double dt_seconds)
        {
            if (!cache.Contains(CacheItemName) || cache.Get(CacheItemName) == null)
            {
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(dt_seconds);
                T elementT = (T)Activator.CreateInstance(typeof(T), CacheItemName);
                cache.Add(CacheItemName, elementT, cacheItemPolicy);
                return elementT;
            }
            return default(T);
        }

        public T Get(string CacheItemName, DateTimeOffset dt)
        {
            if (!cache.Contains(CacheItemName) || cache.Get(CacheItemName) == null)
            {
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = dt;
                T elementT = (T)Activator.CreateInstance(typeof(T), CacheItemName);
                cache.Add(CacheItemName, elementT, cacheItemPolicy);
                return elementT;
            }
            return default(T);
        }


    }
}

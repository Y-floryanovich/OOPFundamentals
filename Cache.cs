using Microsoft.Extensions.Caching.Memory;
using OOPFundamentals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals
{
    public interface ICache<T>
    {
        void AddCache(List<T> items);
    }

    public class Cache<T> : ICache<T>
    {
        private readonly IMemoryCache _memoryCache;
        public void AddCache(List<T> items)
        {
            foreach (var item in items)
            {
                var patent = item as Patent;
                var cacheEntryOptions = new MemoryCacheEntryOptions();
                if (patent != null)
                {
                    cacheEntryOptions.SetSlidingExpiration(patent.ExpirationDate);
                    _memoryCache.Set(item, cacheEntryOptions);
                }
                else
                {
                    _memoryCache.Set(item, cacheEntryOptions);
                }
                    
            }
        }
    }
}

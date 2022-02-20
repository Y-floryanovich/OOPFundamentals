using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;

namespace OOPFundamentals.Entity
{
    public class LibraryDocument<T> : ISearchDocument<T>
    {
        public IStorage<T> Storage;
        public ICache<T> Cache;

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        
        public LibraryDocument(IStorage<T> storage, ICache<T> cache)
        {
            Storage = storage;
            Cache = cache;
        }

        public virtual List<T> GetLibraryDocument(int Id)
        {
            var result = Storage.Read(Id);
            if (result != null)
            {
                Cache.AddCache(result);
            }

            return result;
        }

    }
}

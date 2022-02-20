using System;
using System.Collections.Generic;
namespace OOPFundamentals.Entity
{
    public class LocalizedBook : LibraryDocument<LocalizedBook>
    {
        public LocalizedBook(IStorage<LocalizedBook> storage, ICache<LocalizedBook> cache) : base(storage, cache)
        {
        }

        public List<Author> Authors { get; set; }
        public string ISBN { get; set; }
        public int NumberOfPages { get; set; }
        public string CountryOfLocalization { get; set; }
        public string OriginalPublisher { get; set; }
        public string LocalPublisher { get; set; }

        public override List<LocalizedBook> GetLibraryDocument(int Id)
        {
            return base.GetLibraryDocument(Id);
        }
    }
}

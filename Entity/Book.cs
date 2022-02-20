using System.Collections.Generic;

namespace OOPFundamentals.Entity
{
    public class Book : LibraryDocument<Book>
    {
        public Book(IStorage<Book> storage, ICache<Book> cache) : base(storage, cache)
        {
        }

        public string ISBN { get; set; }
        public List<Author> Authors { get; set; }
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }

        public override List<Book> GetLibraryDocument(int Id)
        {
            return base.GetLibraryDocument(Id);
        }
    }
}

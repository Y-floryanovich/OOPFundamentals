using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.Entity
{
    public class Patent : LibraryDocument<Patent>
    {
        public Patent(IStorage<Patent> storage, ICache<Patent> cache) : base(storage, cache)
        {
        }

        public List<Author> Authors { get; set; }
        public string ISBN { get; set; }
        public TimeSpan ExpirationDate { get; set; }
        public int UniqueId { get; set; }

        public override List<Patent> GetLibraryDocument(int Id)
        {
            return base.GetLibraryDocument(Id);
        }
    }
}

using System;
using System.Collections.Generic;

namespace OOPFundamentals.Entity
{
    public class Magazine : LibraryDocument<Magazine>
    {
        public Magazine(IStorage<Magazine> storage, ICache<Magazine> cache) : base(storage, cache)
        {
        }

        public string Publisher { get; set; }
        public int ReleaseNumber { get; set; }

        public override List<Magazine> GetLibraryDocument(int Id)
        {
            return base.GetLibraryDocument(Id);
        }
    }
}

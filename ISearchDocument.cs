using OOPFundamentals.Entity;
using System.Collections.Generic;

namespace OOPFundamentals
{
    public interface ISearchDocument<T>
    {
        List<T> GetLibraryDocument(int Id);
    }
}

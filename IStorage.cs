using OOPFundamentals.Entity;
using System.Collections.Generic;

namespace OOPFundamentals
{
    public interface IStorage<T>
    {
        List<T> Read(int Id);
    }
}

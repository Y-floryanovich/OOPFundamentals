using OOPFundamentals.Entity;

namespace OOPFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine magazine = new Magazine(new FileStorage<Magazine>(), new Cache<Magazine>());
            var result = magazine.GetLibraryDocument(3);
        }
    }
}

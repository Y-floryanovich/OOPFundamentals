using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using OOPFundamentals.Entity;
using System.Collections.Generic;
using System.IO;

namespace OOPFundamentals
{
    public class FileStorage<T> : IStorage<T>
    {
        public string Path { get; set; }

        public List<T> Read(int Id)
        {
            string resultDocumentString = "type_#" + Id.ToString() + ".json";
            string[] files = Directory.GetFiles(Path);
            List <T> result = new List<T> ();
            foreach (string file in files)
            {
                var number = string.Compare(file, resultDocumentString);
                if (number == 0)
                {
                    string jsonString = File.ReadAllText(file);
                    T myDeserializedClass = JsonConvert.DeserializeObject<T>(jsonString);
                    result.Add(myDeserializedClass);
                }
            }
            return result;
        }
    }
}

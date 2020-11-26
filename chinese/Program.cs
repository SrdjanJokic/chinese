using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace chinese
{
    class Program
    {
        private static readonly string dataFile = "data.json";
        private static Dictionary<string, string> translationBySymbol = new Dictionary<string, string>();

        private static void Main(string[] args)
        {
            // AddNewWord();
        }

        private static void AddNewWord()
        {
            Console.Write("Symbol:");
            string key = Console.ReadLine();
            
            Console.Write("Value:");
            string value = Console.ReadLine();

            // translationBySymbol = JsonConvert.DeserializeObject<Dictionary<string, string>>(dataFile);
            translationBySymbol.Add(key, value);

            string json = JsonConvert.SerializeObject(translationBySymbol, Formatting.Indented);
            File.WriteAllText(dataFile, json);
        }
    }
}

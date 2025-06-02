using Newtonsoft.Json;
using Open_Closed_Principle_Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle_Demo.Utilities
{
    internal class Utilities
    {
        static string ReadFile(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        internal static List<Book> ReadData()
        {
            var cadJSON = ReadFile("Data/BookStore_01.json");
            return JsonConvert.DeserializeObject<List<Book>>(cadJSON);
        }

        internal static List<Book> ReadDataExtra()
        {
            List<Book> books = ReadData();
            var cadJSON = ReadFile("Data/BookStore_02.json");
            books.AddRange(JsonConvert.DeserializeObject<List<Book>>(cadJSON));
            return books;
        }
    }
}

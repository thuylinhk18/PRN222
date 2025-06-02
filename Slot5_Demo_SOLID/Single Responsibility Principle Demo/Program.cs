using Newtonsoft.Json;
using Single_Responsibility_Principle_Demo.Model;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" List of books");
        Console.WriteLine(" ------------------ ");
        var cadJSON = File.ReadAllText("Data/BookStore.json");
        var books = JsonConvert.DeserializeObject<Book[]>(cadJSON);
        foreach( var item in books)
        {
            Console.WriteLine($" {item.Title.PadRight(39, ' ')} " + $"{item.Author.PadRight(15, ' ')} {item.Price}");
        }
        Console.Read();
    }
}
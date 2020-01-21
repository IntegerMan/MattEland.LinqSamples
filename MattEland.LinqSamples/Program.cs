using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace MattEland.LinqSamples
{
    class Program
    {
        static void Main()
        {
            var dataProvider = new BookProvider();

            var books = dataProvider.Books.ToList();

            var grouped = books.GroupBy(b => b.Author, b => b.Title, (key, value) => new
            {
                Author = key,
                Books = value
            });

            Console.WriteLine(GetBookJson(grouped));
        }

        private static string GetBookJson(object books)
        {
            var options = new JsonSerializerOptions();

            // Pretty print
            options.WriteIndented = true;

            // Serialize enum values as strings for better demo purposes
            options.Converters.Add(new JsonStringEnumConverter());

            return JsonConvert.SerializeObject(books, Formatting.Indented); //JsonSerializer.Serialize(books, options);
        }
    }
}

using System;
using System.Linq;

namespace MattEland.LinqSamples
{
    class Program
    {
        static void Main()
        {
            var dataProvider = new BookProvider();

            var books = dataProvider.Books.ToList();

            Console.WriteLine("Hello " + books.First().Title);
        }
    }
}

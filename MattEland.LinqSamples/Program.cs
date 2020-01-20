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

            books.SelectMany()

            Console.WriteLine("Hello " + dataProvider.Books.First().Title);
        }
    }
}

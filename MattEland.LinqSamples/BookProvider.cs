using System;
using System.Collections.Generic;

namespace MattEland.LinqSamples
{
    public class BookProvider
    {
        private Lazy<IEnumerable<Book>> _books = new Lazy<IEnumerable<Book>>(GetBooks);
        public IEnumerable<Book> Books => _books.Value;

        private static IEnumerable<Book> GetBooks()
        {
            var books = new List<Book>
            {
                new Book("Sphere", "Michael Crichton", Genre.ScienceFiction),
                new Book("Working Effectively with Legacy Code", "Michael Feathers", Genre.Technical),
                new Book("Your Code as a Crime Scene", "Adam Tornhill", Genre.Technical),
                new Book("Software Design X-Rays", "Adam Tornhill", Genre.Technical)
            };


            return books;
        }
    }
}
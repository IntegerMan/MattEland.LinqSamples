using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

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
                new Book("Jurassic Park", "Michael Crichton", Genre.ScienceFiction),
                //new Book("Timeline", "Michael Crichton", Genre.ScienceFiction),
                //new Book("Terminal Man", "Michael Crichton", Genre.ScienceFiction),
                //new Book("The Great Train Robbery", "Michael Crichton", Genre.Fiction),
                //new Book("Windows Presentation Foundation Unleashed", "Adam Nathan", Genre.Technical),
                new Book("Working Effectively with Legacy Code", "Michael Feathers", Genre.Technical),
                new Book("Your Code as a Crime Scene", "Adam Tornhill", Genre.Technical),
                new Book("Software Design X-Rays", "Adam Tornhill", Genre.Technical)
            };

            return books;
        }
    }
}
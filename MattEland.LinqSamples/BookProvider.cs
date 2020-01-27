using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MattEland.LinqSamples
{
    public class BookProvider
    {
        private Lazy<IEnumerable<Book>> _books = new Lazy<IEnumerable<Book>>(GetBooks());
        public IEnumerable<Book> Books => _books.Value;

        private static IEnumerable<Book> GetBooks([CallerMemberName] string caller = "")
        {
            var books = new List<Book>
            {
                new Book("Sphere", "Michael Crichton", Genre.ScienceFiction, new List<string>()
                {
                    "Harry",
                    "Norman",
                    "Beth",
                    "Jerry"
                }),
                new Book("Jurassic Park", "Michael Crichton", Genre.ScienceFiction, new List<string>()
                {
                    "Malcolm",
                    "Grant",
                    "Satler",
                    "Nedry",
                    "Hammond",
                    "Gennaro",
                    "Tim",
                    "Lex"
                }),
                //new Book("Timeline", "Michael Crichton", Genre.ScienceFiction),
                //new Book("Terminal Man", "Michael Crichton", Genre.ScienceFiction),
                //new Book("The Great Train Robbery", "Michael Crichton", Genre.Fiction),
                //new Book("Windows Presentation Foundation Unleashed", "Adam Nathan", Genre.Technical),
                new Book("Working Effectively with Legacy Code", "Michael Feathers", Genre.Technical, new List<string>()),
                new Book("Your Code as a Crime Scene", "Adam Tornhill", Genre.Technical, new List<string>()),
                new Book("Software Design X-Rays", "Adam Tornhill", Genre.Technical, new List<string>())
            };

            return books;
        }
    }
}
using System.Linq;

namespace MattEland.LinqSamples
{
    public struct Book
    {
        public string Title { get; }
        public string Author { get; }
        public Genre Genre { get; }

        public Book(string title, string author, Genre genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }
    }
}
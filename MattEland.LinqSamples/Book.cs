using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MattEland.LinqSamples
{
    public struct Book
    {
        public string Title { get; }
        public string Author { get; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Genre Genre { get; }

        public bool IsFiction => Genre != Genre.Technical;

        public Book(string title, string author, Genre genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }
    }
}
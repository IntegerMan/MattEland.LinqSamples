using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using MattEland.LinqSamples;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using StringComparer = System.StringComparer;

namespace MattEland.LinqSamples
{
    public class GenreEntry
    {
        public string Genre { get; set; }
        public IEnumerable<string> Authors { get; set; }
    }

    public class GenreComparer : IEqualityComparer<Genre>
    {
        public bool Equals(Genre x, Genre y) => x == y;

        public int GetHashCode(Genre obj) => obj.GetHashCode();
    }

    class Program
    {
        static void Main()
        {
            var dataProvider = new BookProvider();

            var books = dataProvider.Books.ToList();

            var result = books.SelectMany(b => b.Characters);

            Console.WriteLine(GetBookJson(result));
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

/*
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(
            Func<TSource, IEnumerable<TResult>> selector);

        public static IEnumerable<TResult> SelectMany<TSource, TResult>(
            Func<TSource, int, IEnumerable<TResult>> selector);

        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(
            Func<TSource, IEnumerable<TCollection>> collectionSelector, 
            Func<TSource, TCollection, TResult> resultSelector);

        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(
            Func<TSource, int, IEnumerable<TCollection>> collectionSelector, 
            Func<TSource, TCollection, TResult> resultSelector);
 */

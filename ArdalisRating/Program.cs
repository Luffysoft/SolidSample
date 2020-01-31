using System;

namespace ArdalisRating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ardalis Insurance Rating System Starting...");

            var engine = new RatingEngine();
            var rating = engine.Rate();

            Console.WriteLine(rating > 0 ? $"Rating: {rating}" : "No rating produced.");
        }
    }
}

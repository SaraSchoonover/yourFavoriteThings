using System;
using yourFavoriteThings.Things;

namespace yourFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var salmonRoll = new Sushi
            {
                Name = "Salmon Roll",
                Type = "Sushi"

            };
            salmonRoll.Eat("Japanesa");

            var misoSoup = new Sushi
            {
                Name = "Miso Soup",
                Type = "Soup"
            };
            misoSoup.Slurp();

            var beamanPark = new Hike
            {
                Name = "Beaman Park",
                Type = "Hike"
            };
            beamanPark.Park();

            var trail = new Hike
            {
                Name = "Henry Hollow",
                Type = "hike"
            };
            trail.DifficultyLevel("moderate");

            var Seattle = new City
            {
                Name = "Seattle",
                Type = "urban"
            };
            Seattle.Fly();

            var Avignon = new City
            {
                Name = "Avignon",
                Type = "country side"
            };
            Avignon.Walk();

            var Title = new Book
            {
                Name = "The Catcher in the Rye",
                Type = "fiction"
            };
            Title.Read();

            var Author = new Book
            {
                Name = "J.D. Salinger",
                Type = "author"
            };
            Author.Write();
        }
    }
}

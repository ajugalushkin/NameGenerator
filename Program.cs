using System;
using System.IO;

namespace NameGenerator
{
    class Program
    {
        const string HONORIC_PATH = "dataSorce/honorific-title.txt";
        const string NAME_PATH = "dataSorce/names.txt";
        const string LOCATION_PATH = "dataSorce/locations.txt";
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateName());
        }

        //  Template [honorific/title] [name] of [location]
        public static string GenerateName()
        {
            var rand = new Random();
            string[] honorics = getHonorics();
            string[] names = getNames();
            string[] locations = getLocation();

            string honoric = honorics[rand.Next(0, honorics.Length)];
            string name = names[rand.Next(0, names.Length)];
            string location = locations[rand.Next(0, locations.Length)];

            return $"{ honoric } { name } of { location }";

        }

        private static string[] getHonorics()
        {
            if (File.Exists(HONORIC_PATH))
            {
                return File.ReadAllLines(HONORIC_PATH);
            }
            else
            {
                return new string[] { };
            }
        }

        private static string[] getNames()
        {
            if (File.Exists(NAME_PATH))
            {
                return File.ReadAllLines(NAME_PATH);
            }
            else
            {
                return new string[] { };
            }
        }

        private static string[] getLocation()
        {
            if (File.Exists(LOCATION_PATH))
            {
                return File.ReadAllLines(LOCATION_PATH);
            }
            else
            {
                return new string[] { };
            }
        }
    }
}

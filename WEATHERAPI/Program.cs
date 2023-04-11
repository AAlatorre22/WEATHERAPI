using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System.Threading.Channels;


namespace WEATHERAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIkey = JObject.Parse(key).GetValue("DefaultKey").ToString();

            var cont = true;
            do
            {
                Console.WriteLine("Please enter zipcode to get current weather conditions!");
                var zipCode = Console.ReadLine();
                Console.WriteLine();
                string apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIkey}&units=imperial";
                Console.WriteLine("()()()()()()()()()()()()()()()()()()()()()()()()()()()");
                Console.WriteLine($"Weather for {Weather.City(apiCall)}!");
                Console.WriteLine("======================================================");
                Console.WriteLine($"Current condition: {Weather.Descript(apiCall)}");
                Console.WriteLine($"Current temperature: {Weather.Temp(apiCall)}°F");
                Console.WriteLine($"Feels like: {Weather.FeelsLike(apiCall)}°F");
                Console.WriteLine($"Today's low: {Weather.Min(apiCall)}°F");
                Console.WriteLine($"Today's high: {Weather.Max(apiCall)}°F");
                Console.WriteLine($"Humidity: {Weather.Humid(apiCall)}%");
                Console.WriteLine("======================================================");
                Console.WriteLine();

                Console.WriteLine("Would you like to check weather for a diferent zip code?");
                Console.WriteLine("Y or N?");
                Console.WriteLine();

                var userAns = Console.ReadLine().ToLower();

                cont = (userAns == "n") ? false : true;
            } while (cont);

            Console.WriteLine();
            Console.WriteLine("Have a wonderful day!");
            Console.WriteLine("()()()()()()()()()()()()()()()()()()()()()()()()()()()");


        }
    }
}
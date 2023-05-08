using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEATHERAPI
{
    public static class CurrentWeather
    {

        public static void CurrWeath()
        {

            string key = File.ReadAllText("appsettings.json");
            string APIkey = JObject.Parse(key).GetValue("DefaultKey").ToString();

            var cont = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter zipcode to get current weather conditions!");
                Console.ResetColor();
                var zipCode = Console.ReadLine();
                Console.WriteLine();
                string apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIkey}&units=imperial";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("()()()()()()()()()()()()()()()()()()()()()()()()()()()");
                Console.ResetColor();
                Console.WriteLine($"Weather for {Weather.City(apiCall)}!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("======================================================");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Current condition: {Weather.Descript(apiCall)}");
                Console.WriteLine($"Current temperature: {Weather.Temp(apiCall)}°F");
                Console.WriteLine($"Feels like: {Weather.FeelsLike(apiCall)}°F");
                Console.WriteLine($"Today's low: {Weather.Min(apiCall)}°F");
                Console.WriteLine($"Today's high: {Weather.Max(apiCall)}°F");
                Console.WriteLine($"Humidity: {Weather.Humid(apiCall)}%");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("======================================================");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Would you like to check weather for a diferent zip code?");
                Console.WriteLine("Y or N?");
                Console.WriteLine();

                var userAns = Console.ReadLine().ToLower();

                cont = (userAns == "n") ? false : true;
            } while (cont);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Have a wonderful day!");
            Console.WriteLine("()()()()()()()()()()()()()()()()()()()()()()()()()()()");
            Console.ReadLine();
        }
    }


}

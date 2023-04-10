using static System.Net.WebRequestMethods;

namespace WEATHERAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var weatherURL = "https://api.openweathermap.org/data/2.5/weather?id={city id}&appid={API key}";
            var weatherResponse = client.GetStringAsync(weatherURL).Result;
            Console.WriteLine(weatherResponse);



        }
    }
}
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace WEATHERAPI
{
    public static class Weather
    {
        public static double Temp(string apiCall)
        {
            var client = new HttpClient();

            var response = client.GetStringAsync(apiCall).Result;

            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

            return temp;
            

        }
        public static double Min(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var min = double.Parse(JObject.Parse(response)["main"]["temp_min"].ToString());
            return min;


        }
        public static double Max(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var max = double.Parse(JObject.Parse(response)["main"]["temp_max"].ToString());
            return max;
        }
        public static string Descript(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var descript = JObject.Parse(response)["weather"][0]["main"].ToString();
            return descript;
        }
        public static string City(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var city = JObject.Parse(response)["name"].ToString();
            return city;
        }
        public static double Humid(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var humid = double.Parse(JObject.Parse(response)["main"]["humidity"].ToString());
            return humid;
        }
        public static double FeelsLike(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var feel = double.Parse(JObject.Parse(response)["main"]["feels_like"].ToString());
            return feel;
        }

    }
}

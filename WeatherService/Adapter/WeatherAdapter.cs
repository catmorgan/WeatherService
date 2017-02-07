using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using WeatherService.Adapter.Interfaces;

namespace WeatherService.Adapter
{
    public class WeatherAdapter : IWeatherAdapter
    {
        //https://home.openweathermap.org/api_keys
        private HttpClient OpenWeatherMapClient;
        private string apiKey = "5d84e96fa33e90a2df688e4e83fb3901";

        public WeatherAdapter()
        {
            OpenWeatherMapClient = new HttpClient();
        }
    }
}
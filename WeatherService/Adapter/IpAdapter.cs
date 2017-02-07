using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using WeatherService.Adapter.Interfaces;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherService.Models;

namespace WeatherService.Adapter
{
    public class IpAdapter : IIpAdapter
    {
        private HttpClient ipClient;
        
        public IpAdapter()
        {
            ipClient = new HttpClient();
        }

        public async Task<string> GetIpAddress()
        {
            var ipAddress = "";
            var response = await ipClient.GetAsync("https://api.ipify.org?format=json");
            var content = await response.Content.ReadAsStringAsync();
            var parsedResponse = JsonConvert.DeserializeObject<dynamic>(content);
            ipAddress = parsedResponse["ip"].Value;
            return ipAddress;
        }

        public async Task<UserLocation> GetUserLocation(string ipAddress)
        {
            var response = await ipClient.GetAsync($"http://ip-api.com/json/{ipAddress}");
            var content = await response.Content.ReadAsStringAsync();
            var userLocation = JsonConvert.DeserializeObject<UserLocation>(content);
            return userLocation;
        }
    }
}
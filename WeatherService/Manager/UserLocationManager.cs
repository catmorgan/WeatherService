using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using WeatherService.Adapter;
using WeatherService.Adapter.Interfaces;
using WeatherService.Manager.Interfaces;
using WeatherService.Models;

namespace WeatherService.Manager
{
    public class UserLocationManager : IUserLocationManager
    {
        private IIpAdapter IpAdapter;

        public UserLocationManager(IIpAdapter _ipAdapter)
        {
            IpAdapter = _ipAdapter;
        }

        public async Task<string> GetIpAddress()
        {
            return await IpAdapter.GetIpAddress();
        }

        public async Task<UserLocation> GetUserLocation(string ipAddress)
        {
            return await IpAdapter.GetUserLocation(ipAddress);
        }
    }
}
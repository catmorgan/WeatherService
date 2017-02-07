using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService.Models;

namespace WeatherService.Manager.Interfaces
{
    public interface IUserLocationManager
    {
        Task<string> GetIpAddress();
        Task<UserLocation> GetUserLocation(string ipAddress);
    }
}

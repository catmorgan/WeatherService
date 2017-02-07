using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService.Models;

namespace WeatherService.Adapter.Interfaces
{
    public interface IIpAdapter
    {
        Task<string> GetIpAddress();
        Task<UserLocation> GetUserLocation(string ipAddress);
    }
}

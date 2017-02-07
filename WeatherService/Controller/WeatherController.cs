using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using WeatherService.Manager.Interfaces;

namespace WeatherService.Controller
{
    public class WeatherController : ApiController
    {
        private IUserLocationManager UserLocationManager;

        public WeatherController(IUserLocationManager _userLocationManager)
        {
            UserLocationManager = _userLocationManager;
        }
        
        [HttpGet]
        public async Task<string> IpTest()
        {
            var userIpAddress = System.Web.HttpContext.Current.Request.IsLocal ? 
                await UserLocationManager.GetIpAddress() : System.Web.HttpContext.Current.Request.UserHostAddress;

            var userLocation = await UserLocationManager.GetUserLocation(userIpAddress);

            return userIpAddress;
        }
    }
}

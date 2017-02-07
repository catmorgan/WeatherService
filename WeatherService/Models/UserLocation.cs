using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherService.Models
{
    public class UserLocation
    {
        public string City { get;set;}
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Region { get; set; }
        public string RegionName { get; set; }
        public string Zip { get; set; }
    }
}
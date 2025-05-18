using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApp.Core
{
    public class Location
    {
        public  double Latitude { get; set; }
        public double Longitude { get; set; }

        public Location(double lat, double lng)
        {
            Latitude = lat; 
            Longitude = lng;
        }

        public double DistanceTo(Location other)
        {
            return Math.Sqrt(Math.Pow((Latitude-other.Latitude), 2) + Math.Pow((Longitude-other.Longitude), 2));
        }
    }
}

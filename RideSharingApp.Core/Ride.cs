using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApp.Core
{
    public class Ride
    {
        public int RideId { get; set; }
        public User Rider { get; set; }
        public Vehicle Vehicle { get; set; }
        public Location Start {  get; set; }
        public Location End { get; set; }
        public double Distance { get; set; }
        public decimal Fare { get; set; }

        public Ride(int rideId, User rider, Vehicle vehicle, Location start, Location end)
        {
            RideId = rideId;
            Rider = rider;
            Vehicle = vehicle;
            Start = start;
            End = end;
            Distance = start.DistanceTo(end);
            Fare = CalculatedFare();
        }

        private decimal CalculatedFare()
        {
            return (decimal)(Distance * 10);
        }
    }
}

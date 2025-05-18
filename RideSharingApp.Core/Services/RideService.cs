using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApp.Core.Services
{
    public class RideService
    {
        private readonly DriverService _driverService;
        private readonly List<Ride> _rides = new();
        private int _rideIdCounter = 1;

        public RideService(DriverService driverService)
        {
            _driverService = driverService;
        }

        public Ride? StartRide(User rider,Location start, Location end)
        {
            var vehicle = _driverService.FindVehiclesNearby(start);
            if (vehicle == null) return null;

            var ride = new Ride(_rideIdCounter++, rider, vehicle, start, end);
            _rides.Add(ride);
            _driverService.MarkVehicleUnavailable(vehicle);
            return ride;
        }

        public void CompleteRide(Ride ride)
        {
            _driverService.MarkVehicleAvailable(ride.Vehicle);
        }

        public List<Ride> GetAllUserRides(User user)
        {
            return _rides.FindAll(x => x.Rider.Id == user.Id);
        }
    }
}

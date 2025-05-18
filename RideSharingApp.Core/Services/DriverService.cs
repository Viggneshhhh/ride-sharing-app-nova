using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApp.Core.Services
{
    public class DriverService
    {
        private readonly List<Vehicle> _availableVehicles = new();

        public void RegisterDriver(Vehicle vehicle)
        {
            _availableVehicles.Add(vehicle);
        }

        public void UpdateLocation(Vehicle vehicle, Location newLocation)
        {
            vehicle.Driver.CurrentLocation = newLocation;
        }

        public Vehicle? FindVehiclesNearby(Location userLocation)
        {
            return _availableVehicles.OrderBy(x=>x.Driver.CurrentLocation.DistanceTo(userLocation)).FirstOrDefault();
        }

        public void MarkVehicleUnavailable(Vehicle vehicle)
        {
            _availableVehicles.Remove(vehicle);
        }

        public void MarkVehicleAvailable(Vehicle vehicle)
        {
            if (!_availableVehicles.Contains(vehicle))
            {
                _availableVehicles.Add(vehicle);
            }
        }
    }
}

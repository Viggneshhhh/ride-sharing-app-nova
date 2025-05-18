using RideSharingApp.Core;
using RideSharingApp.Core.Services;
using System;
using System.Collections.Generic;
using RideSharingApp.Core;

namespace RideSharingApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup
            var driverService = new DriverService();
            var rideService = new RideService(driverService);

            // Create Driver
            var driverUser = new User("Alice", UserType.Driver)
            {
                CurrentLocation = new Location(10, 10)
            };

            var vehicle = new Vehicle("KA01AB1234", "Honda City", driverUser);
            driverService.RegisterDriver(vehicle);

            // Create Rider
            var riderUser = new User("Bob", UserType.Rider);

            // Rider's desired ride
            var startLocation = new Location(10.5, 10.5);
            var endLocation = new Location(12, 12);

            // Start ride
            var ride = rideService.StartRide(riderUser, startLocation, endLocation);

            if (ride != null)
            {
                Console.WriteLine($"✅ Ride started!");
                Console.WriteLine($"Driver: {ride.Vehicle.Driver.Name}");
                Console.WriteLine($"From: ({ride.Start.Latitude}, {ride.Start.Longitude})");
                Console.WriteLine($"To: ({ride.End.Latitude}, {ride.End.Longitude})");
                Console.WriteLine($"Distance: {ride.Distance:F2} km");
                Console.WriteLine($"Fare: ₹{ride.Fare}");

                // Complete the ride
                rideService.CompleteRide(ride);
                Console.WriteLine("✅ Ride completed.");
            }
            else
            {
                Console.WriteLine("❌ No available drivers found.");
            }

            // Show ride history
            var history = rideService.GetAllUserRides(riderUser);
            Console.WriteLine($"\n📜 {riderUser.Name}'s ride history:");
            foreach (var r in history)
            {
                Console.WriteLine($"Ride ID: {r.RideId}, Fare: ₹{r.Fare}");
            }
        }
    }
}

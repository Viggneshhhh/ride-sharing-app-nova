using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApp.Core
{
    public class Vehicle
    {
        public string PlateNumber { get; set; }
        public string Model { get; set; }
        public User Driver { get; set; }

        public Vehicle(string plateNumber, string model, User driver) 
        {
            PlateNumber = plateNumber;
            Model = model;
            Driver = driver;
        }
    }
}

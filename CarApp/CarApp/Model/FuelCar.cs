using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Model
{
    public class FuelCar : Car
    {
        public double FuelLevel { get; private set; } 
        public double TankCapacity { get; private set; }
        public double KmPerLiter { get; private set; }


        // Test FuelCar (Brand, Model, Licenseplate, TankCapacity, KmPerLiter)

        public FuelCar(string brand, string model, string licensePlate, double tankCapacity, double kmPerLiter)
        {
            this.Brand = brand;
            this.Model = model;
            this.LicensePlate = licensePlate;
            this.TankCapacity = tankCapacity;
            this.KmPerLiter = kmPerLiter;
            this.IsEngineOn = false;
            this.Odometer = 0;
        }

        public void Refuel(double amount)
        {
            FuelLevel = FuelLevel + amount;
            if (FuelLevel > TankCapacity)
            {
                FuelLevel = TankCapacity;
            }
        }

        public override void Drive(double distance)
        {
            FuelLevel = FuelLevel - (distance / KmPerLiter);
            if (FuelLevel < 0)
            {
                FuelLevel = 0;
            }
        }


    }
}

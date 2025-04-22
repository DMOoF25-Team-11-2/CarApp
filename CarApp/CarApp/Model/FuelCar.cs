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

        public FuelCar()
        {
            
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
            
        }


    }
}

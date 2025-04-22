using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Model
{
    public class FuelCar : Car
    {
        public double fuelLevel { get; private set; } 
        public double TankCapacity { get; private set; }
        public double KmPerLiter { get; private set; }

        public FuelCar()  { }

        public void Refuel (double amount) { }

        public override void Drive (double distance) { }


    }
}

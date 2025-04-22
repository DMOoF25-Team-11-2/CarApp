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

        public override bool CanDrive()
        {
            return IsEngineOn && FuelLevel > 0;
        }

        public override double CalculateConsumption(double distance)
        {
            return distance / KmPerLiter;
        }

        public override void UpdateEnergyLevel(double distance)
        {
            FuelLevel -= CalculateConsumption(distance);
            if (FuelLevel < 0)
            {
                FuelLevel = 0;
            }
        }

        public void Drive(double distance)
        {
            if (CanDrive())
            {
                Odometer += (int)distance;
                UpdateEnergyLevel(distance);
            }
            else
            {
                throw new InvalidOperationException("Cannot drive. Engine is off or fuel level is too low.");
            }
        }

    }
}

namespace CarApp.Model
{
    public class FuelCar : Car, IEnergy
    {
        public double FuelLevel { get; set; }
        public double TankCapacity { get; set; }
        public double KmPerLiter { get; set; }
        public double EnergyLevel { get => FuelLevel; }
        public double MaxEnergy { get => TankCapacity; }

        // Test FuelCar (Brand, Model, Licenseplate, TankCapacity, KmPerLiter)  

        public FuelCar(string brand, string model, string licensePlate, double tankCapacity, double kmPerLiter)
            : base(brand, model, licensePlate)
        {
            TankCapacity = tankCapacity;
            KmPerLiter = kmPerLiter;
            FuelLevel = tankCapacity; // Start with a full tank
        }

        public void Refill(double amount)
        {
            FuelLevel += amount;
            if (FuelLevel > TankCapacity)
            {
                FuelLevel = TankCapacity;
            }
        }

        public void UseEnergy(double km)
        {
            if (km < 0)
            {
                throw new ArgumentException("Distance cannot be negative.");
            }
            FuelLevel -= km / KmPerLiter;
        }

        public override bool CanDrive(double km)
        {
            if (km < 0)
            {
                throw new ArgumentException("Distance cannot be negative.");
            }
            double requiredFuel = km / KmPerLiter;
            return FuelLevel >= requiredFuel;
        }
    }
}

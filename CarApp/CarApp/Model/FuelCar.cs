namespace CarApp.Model
{
    public class FuelCar : Car, IEnergy
    {
        public double FuelLevel { get; set; }
        public double TankCapacity { get; set; }
        public double KmPerLiter { get; set; }
        public double EnergyLevel { get; set; }
        public double MaxEnergy { get; set; }

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
            FuelLevel -= km / KmPerLiter;
        }

        public override bool CanDrive(double km)
        {
            double requiredFuel = km / KmPerLiter;
            return FuelLevel >= requiredFuel;
        }
    }
}

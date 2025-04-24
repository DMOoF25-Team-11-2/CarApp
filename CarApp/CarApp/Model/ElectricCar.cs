namespace CarApp.Model;

public class ElectricCar : Car, IEnergy
{
    public double BatteryLevel { get; set; }
    public double BatteryCapacity { get; set; }
    public double KmPerKWh { get; set; }
    public double EnergyLevel { get => BatteryLevel; }
    public double MaxEnergy { get => BatteryCapacity; }

    public ElectricCar(string brand, string model, string licensePlate, double batteryCapacity, double kmPerKWh)
        : base(brand, model, licensePlate)
    {
        BatteryCapacity = batteryCapacity;
        KmPerKWh = kmPerKWh;
        BatteryLevel = 0; // Start with a full battery
    }

    public override bool CanDrive(double km)
    {
        if (km < 0)
        {
            throw new ArgumentException("Distance cannot be negative.");
        }
        double requiredFuel = km / KmPerKWh;
        return BatteryLevel >= requiredFuel;
    }

    public void Refill(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount to refill must be positive.");
        }
        BatteryLevel += amount;
        if (BatteryLevel > BatteryCapacity)
        {
            BatteryLevel = BatteryCapacity; // Cap at max capacity
        }
    }

    public void UseEnergy(double km)
    {
        if (km < 0)
        {
            throw new ArgumentException("Distance cannot be negative.");
        }
        double energyUsed = km / KmPerKWh;
        if (energyUsed > BatteryLevel)
        {
            throw new InvalidOperationException("Not enough battery to drive the distance.");
        }
        BatteryLevel -= energyUsed;
    }

    public void Drive(double km)
    {
        if (CanDrive(km))
        {
            base.Drive(km);
            UseEnergy(km);
        }
        else
        {
            throw new InvalidOperationException("Not enough energy to drive.");
        }
    }
}
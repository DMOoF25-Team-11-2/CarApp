namespace CarApp.Model;

public class ElectricCar : Car
{
    public double BatteryLevel { get; set; }
    public double BatteryCapacity { get; set; }
    public double KmPerKWh { get; set; }


    // Test ElectricCar (Brand, Model, Licenseplate, BatteryCapacity, KmPerLiter)

    public ElectricCar(string brand, string model, string licensePlate, double batteryCapacity, double kmPerKWh)
    {
        this.Brand = brand;
        this.Model = model;
        this.LicensePlate = licensePlate;
        this.BatteryCapacity = batteryCapacity;
        this.KmPerKWh = kmPerKWh;
        this.IsEngineOn = false;
        this.Odometer = 0;
    }

    public void Charge(double amount)
    {
        BatteryLevel = BatteryLevel + amount;
        
        if (BatteryLevel > BatteryCapacity)
        {
            BatteryLevel = BatteryCapacity;
        }
    }

    public override void Drive(double distance)
    {
        BatteryLevel = BatteryLevel - (distance / KmPerKWh);
        
        if (BatteryLevel < 0)
        {
            BatteryLevel = 0;
        }
        Odometer += (int)distance;
    }
}
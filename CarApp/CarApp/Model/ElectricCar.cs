namespace CarApp.Model;

public class ElectricCar : Car
{
    public double BatteryLevel { get; set; }
    public double BatteryCapacity { get; set; }
    public double KmPerKWh { get; set; }

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
    }
}
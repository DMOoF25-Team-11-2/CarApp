namespace CarApp.Model;

public class ElectricCar : Car
{
    public double BatteryLevel { get; set; }
    public double BatteryCapacity { get; set; }
    public double KmPerKWh { get; set; }

    public void Charge(double amount)
    {
        
    }

    public override void Drive(double distance)
    {
        
    }
}
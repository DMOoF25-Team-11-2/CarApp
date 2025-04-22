namespace CarApp.Model;

public abstract class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string LicensePlate { get; set; }
    public bool IsEngineOn { get; set; }
    public int Odometer { get; set; }

   

    public void StartEngine ()
    { 
        IsEngineOn = true;
    }
    public void StopEngine () 
    {
        IsEngineOn = false;
    }
    public abstract bool CanDrive();
    public abstract void UpdateEnergyLevel(double distance);
    public abstract double CalculateConsumption(double distance);

}
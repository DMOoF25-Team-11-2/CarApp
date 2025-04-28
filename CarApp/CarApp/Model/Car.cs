namespace CarApp.Model;

public abstract class Car : IDrivable
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string LicensePlate { get; set; }
    public int Odometer { get; set; }
    public bool IsEngineRunning { get; set; }
    
    public List<Trip> Trips { get; set; }

    public Car(string brand, string model, string licensePlate)
    {
        Brand = brand;
        Model = model;
        LicensePlate = licensePlate;
        IsEngineRunning = false;
        Odometer = 0;
    }

    public void StartEngine()
    {
        IsEngineRunning = true;
    }
    public void StopEngine()
    {
        IsEngineRunning = false;
    }

    public void Drive(double distance)
    {
        Odometer += (int)distance;
    }

    public abstract bool CanDrive(double km);

}


/// Test push from branch task 10
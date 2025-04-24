namespace CarApp.Model;

public abstract class Car : IDrivable
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string LicensePlate { get; set; }
    public int Odometer { get; set; }
    public bool IsEngineRunning { get; set; }

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
        if (CanDrive(distance))
        {
            Odometer += (int)distance;
        }
        else
        {
            throw new InvalidOperationException("Not enough fuel or battery to drive the distance.");
        }
    }

    public abstract bool CanDrive(double distance);

}
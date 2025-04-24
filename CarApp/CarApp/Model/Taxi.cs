namespace CarApp.Model;

class Taxi : Car
{
    public double StartPrice { get; set; }
    public double PricePerKm { get; set; }
    public double PricePerMinute { get; set; }
    public bool MeterStarted { get; set; }

    public Taxi(string brand, string model, string licensePlate, double startPrice, double pricePerKm, double pricePerMinute)
        : base(brand, model, licensePlate)
    {
        StartPrice = startPrice;
        PricePerKm = pricePerKm;
        PricePerMinute = pricePerMinute;
        MeterStarted = false;
    }

    public void StartMeter()
    {
        MeterStarted = true;
    }

    public void StopMeter()
    {
        MeterStarted = false;
    }

    public double CalculateFare(double distance, double time)
    {
        if (MeterStarted)
        {
            return StartPrice + (PricePerKm * distance) + (PricePerMinute * time);
        }
        else
        {
            return 0;
        }
    }

    public override bool CanDrive(double km)
    {
        // Assuming taxis can always drive if the engine is running
        return IsEngineRunning;
    }




}




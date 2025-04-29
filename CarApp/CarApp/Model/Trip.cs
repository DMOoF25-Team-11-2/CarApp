namespace CarApp.Model;

public class Trip
{
    public string CarRegNr { get; set; }
    double Distance { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; private set; }

    public override string ToString()
    {
        return $"{CarRegNr} {Date} {StartTime} {EndTime}";
    }

    public Trip FromString(string input)
    {
        return this;
    }

}
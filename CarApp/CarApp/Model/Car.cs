using System.Xml.Schema;

namespace CarApp.Model;

public class Car 
{
    
    public string Make { get; set; }
    public string Model { get; set; }
    
    public int Year { get; set; }
    
    public string Color { get; set; }
    public string LicensePlate { get; set; }
    
    public string FuelType { get; set; }
    
    public List<Trip> Trips { get; set; }

    public Car(string make, string model, int year, string color, string licensePlate, string fuelType)
    {
        Trips = new List<Trip>();
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.Color = color;
        this.LicensePlate = licensePlate;
        this.FuelType = fuelType;
    }


    public string ToString()
    {
       return $"{Make},{Model},{Year},{Color},{LicensePlate},{FuelType}";
    }

    public static Car FromString(string input)
    {
        string[] carInfo = input.Split(',');
        Car newCar = new Car(carInfo[0],carInfo[1],Int32.Parse(carInfo[2]),carInfo[3],carInfo[4],carInfo[5]);
        return newCar;
    }
}


/// Team 14 rocks
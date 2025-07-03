namespace CarConsoleApp;

using System.Xml.Schema;
using CarLibrary.Models;
internal class Program
{
    static void Main(string[] args)
    {
       ElectricCar car = new ElectricCar();

        car.Model = "Telsa";
        car.EnergyLevel = 1;
        car.LicensePlate = "AE45621";
        car.Odometer = 18500;


        CarRepository Database = new CarRepository();

        Database.Add(
        new ElectricCar()
        {
           Model = "Tesla",
           EnergyLevel = 1,
           LicensePlate = "AE45621",
           Odometer = 18500
        }
        );

        Database.Add(car);
    }
}

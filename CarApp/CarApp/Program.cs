namespace CarApp;
using CarApp.Model;
using CarApp.Repositories;
internal class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("volvo", "S60", 2000, "Rød", "XX293848", "Benzin");
        FileCarRepository db = new FileCarRepository("./db.txt");
        db.AddCar(car1);
        var cars = db.GetAllCars();
        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }
}

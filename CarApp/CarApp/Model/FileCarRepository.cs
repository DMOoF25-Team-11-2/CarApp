using CarApp.Repositories;

namespace CarApp.Model;

public class FileCarRepository : ICarRepository
{
    public string filePath;

    public FileCarRepository(string filePath)
    {
        this.filePath = filePath;
    }

    public List<Car> GetAllCars()
    {
        List<Car> cars = new List<Car>();
        using (StreamReader sr = new StreamReader(filePath))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                cars.Add(Car.FromString(line));
            }
        }
        return new List<Car>();
    }

    public Car GetCar(string licensePlate)
    {
        List<Car> cars = new List<Car>();
        cars = GetAllCars();
        var car = cars.Where(x => x.LicensePlate == licensePlate).FirstOrDefault();
        return car;
    }

    public void AddCar(Car car)
    {
        //Dette giver fejl og overskriver hele filen
        string carStr = car.ToString();
        using (StreamWriter sw = File.AppendText(filePath)) 
        {
            sw.WriteLine(carStr);
        }
    }

    public void UpdateCar(Car car)
    {
        DeleteCar(car.LicensePlate);
        AddCar(car);
    }

    public void DeleteCar(string licensePlate)
    {
        List<Car> cars = new List<Car>();
        cars = GetAllCars();
        cars.Remove(GetCar(licensePlate));
        File.Delete(filePath);
        foreach (var car in cars)
        {
            AddCar(car);
        }
    }

}
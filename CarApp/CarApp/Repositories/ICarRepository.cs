using CarApp.Model;

namespace CarApp.Repositories;

public interface ICarRepository
{
    IEnumerable<Car> GetAllCars();
    Car? GetCar(string licensePlate);
    void AddCar(Car car);
    void UpdateCar(Car car);
    void DeleteCar(string licensePlate);

}
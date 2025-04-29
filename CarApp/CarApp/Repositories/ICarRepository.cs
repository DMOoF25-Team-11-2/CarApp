using CarApp.Model;

namespace CarApp.Repositories;

public interface ICarRepository
{
    public List<Car> GetAllCars();
    public Car? GetCar(string licensePlate);
    void AddCar(Car car);
    void UpdateCar(Car car);
    void DeleteCar(string licensePlate);

}
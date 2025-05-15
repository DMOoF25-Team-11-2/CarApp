using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary.Models;

public class CarRepository : ICarRepository
{
    public ICollection<Car> cars;
    public CarRepository()
    {
        cars = [];
    }

    public void Add(Car car)
    {
        cars.Add(car);
    }

    public void Delete(Car car)
    {
        cars.Remove(car);
    }

    public Car? FindByLicensePlate(string licensePlate)
    {
      return cars.Where(c => c.LicensePlate == licensePlate).FirstOrDefault();
    }

    public IEnumerable<Car> GetAll()
    {
        return cars;
    }

    public void Update(Car car)
    {
        cars.Where(c => c.Equals(car)).FirstOrDefault();
    }

   
}

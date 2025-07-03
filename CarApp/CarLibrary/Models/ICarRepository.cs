using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary.Models;

public interface ICarRepository
{
   
    void Add(Car car);
    void Delete(Car car);
    void Update(Car car);
    IEnumerable<Car> GetAll();
    Car? FindByLicensePlate(string licensePlate);
}

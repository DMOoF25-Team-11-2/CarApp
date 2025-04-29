using CarApp.Model;

namespace CarApp.Repositories;

public interface ITripRepository
{
    IEnumerable<Trip> GetAllTrips();
    Trip? GetTrip(string licensePlate);
    void AddTrip(Trip car);
    void UpdateTrip(Trip car);
    void DeleteTrip(string licensePlate);
}
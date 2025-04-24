namespace CarApp.Model;

interface IEnergy
{
    double EnergyLevel { get; set; }
    double MaxEnergyLevel { get; set; }

    void Refill(double amount);
    void UseEnergy(double km);
}

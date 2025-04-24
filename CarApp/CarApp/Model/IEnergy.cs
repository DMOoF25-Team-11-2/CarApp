namespace CarApp.Model;

public interface IEnergy
{
    public double EnergyLevel { get; set; }
    public double MaxEnergyLevel { get; set; }

    public void Refill(double amount);
    public void UseEnergy(double km);
}

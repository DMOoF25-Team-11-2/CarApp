namespace CarApp.Model;

public interface IEnergy
{
    public double EnergyLevel { get; }
    public double MaxEnergy { get; }

    public void Refill(double amount);
    public void UseEnergy(double km);
}

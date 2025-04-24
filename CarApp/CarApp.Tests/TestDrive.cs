namespace CarApp.Tests;
[TestClass]
public sealed class TestDrive
{
    [TestMethod]
    public void TestElectricCar()

    {
        // Arrange
        var car = new Model.ElectricCar("Tesla", "Model S", "ABC123", 100, 5);
        car.StartEngine();
        car.Charge(50);
        // Act
        car.Drive(100);
        // Assert
        Assert.AreEqual(30, car.BatteryLevel, $"Battery level {car.BatteryLevel} should be 30");
        Assert.AreEqual(100, car.Odometer, $"Odometer {car.Odometer} should be 100");
    }
    [TestMethod]
    public void TestFuelCar()

    {
        // Arrange
        var car = new Model.FuelCar("Seat", "Arona", "BE25546", 45, 19);
        car.StartEngine();
        car.Refuel(40);
        // Act
        car.Drive(57);
        // Assert
        Assert.AreEqual(37, car.FuelLevel, $"Fuel level {car.FuelLevel} should be 37");
        Assert.AreEqual(57, car.Odometer, $"Odometer {car.Odometer} should be 57");

    }
}

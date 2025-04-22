namespace TestCarApp;
using CarApp;
[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()

    {
        // Arrange
        var car = new CarApp.Model.ElectricCar("Tesla", "Model S", "ABC123", 100, 5);
        car.StartEngine();
        car.Charge(50);
        // Act
        car.Drive(100);
        // Assert
        Assert.AreEqual(30, car.BatteryLevel);
        Assert.AreEqual(100, car.Odometer);
    }
    [TestMethod]
    public void TestMethod2()

    {
        // Arrange
        var car = new CarApp.Model.FuelCar("Seat", "Arona", "BE25546", 45, 19);
        car.StartEngine();
        car.Refuel(40);
        // Act
        car.Drive(57);
        // Assert
        Assert.AreEqual(37, car.FuelLevel);
        Assert.AreEqual(57, car.Odometer);
        
    }
}

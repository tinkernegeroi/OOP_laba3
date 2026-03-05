using OOP_laba3.classes;
using OOP_laba3.services;

namespace AirportTests;

[TestClass]
public class RandomAbstractFactoryTests
{
    private readonly RandomAbstractFactory _factory = new RandomAbstractFactory();

    // ─── CreateAirport ───────────────────────────────────────────────────────

    [TestMethod]
    public void CreateAirport_ReturnsNotNull()
    {
        Airport airport = _factory.CreateAirport();
        Assert.IsNotNull(airport);
    }

    [TestMethod]
    public void CreateAirport_ReturnsAirportInstance()
    {
        var result = _factory.CreateAirport();
        Assert.IsInstanceOfType(result, typeof(Airport));
    }

    [TestMethod]
    public void CreateAirport_NameIsNotEmpty()
    {
        Airport airport = _factory.CreateAirport();
        Assert.IsFalse(string.IsNullOrWhiteSpace(airport.Name));
    }

    [TestMethod]
    public void CreateAirport_LocationIsNotEmpty()
    {
        Airport airport = _factory.CreateAirport();
        Assert.IsFalse(string.IsNullOrWhiteSpace(airport.Location));
    }

    [TestMethod]
    public void CreateAirport_FlightsPerDayInRange()
    {
        for (int i = 0; i < 20; i++)
        {
            Airport airport = _factory.CreateAirport();
            Assert.IsTrue(airport.FlightsPerDay >= 10 && airport.FlightsPerDay < 200,
                $"FlightsPerDay={airport.FlightsPerDay} вне диапазона [10, 200)");
        }
    }

    [TestMethod]
    public void CreateAirport_TicketsSoldInRange()
    {
        for (int i = 0; i < 20; i++)
        {
            Airport airport = _factory.CreateAirport();
            Assert.IsTrue(airport.TicketsSold >= 100 && airport.TicketsSold < 5000,
                $"TicketsSold={airport.TicketsSold} вне диапазона [100, 5000)");
        }
    }

    [TestMethod]
    public void CreateAirport_BalanceIsNonNegative()
    {
        for (int i = 0; i < 20; i++)
        {
            Airport airport = _factory.CreateAirport();
            Assert.IsTrue(airport.Balance >= 0,
                $"Balance={airport.Balance} отрицательный");
        }
    }

    [TestMethod]
    public void CreateAirport_RatingInRange()
    {
        for (int i = 0; i < 20; i++)
        {
            Airport airport = _factory.CreateAirport();
            Assert.IsTrue(airport.Rating >= 0.0 && airport.Rating <= 5.0,
                $"Rating={airport.Rating} вне диапазона [0, 5]");
        }
    }

    [TestMethod]
    public void CreateAirport_EmployeesCountInRange()
    {
        for (int i = 0; i < 20; i++)
        {
            Airport airport = _factory.CreateAirport();
            Assert.IsTrue(airport.EmployeesCount >= 50 && airport.EmployeesCount < 2000,
                $"EmployeesCount={airport.EmployeesCount} вне диапазона [50, 2000)");
        }
    }

    // ─── CreateAirplane ──────────────────────────────────────────────────────

    [TestMethod]
    public void CreateAirplane_ReturnsNotNull()
    {
        Airplane airplane = _factory.CreateAirplane();
        Assert.IsNotNull(airplane);
    }

    [TestMethod]
    public void CreateAirplane_ReturnsAirplaneInstance()
    {
        var result = _factory.CreateAirplane();
        Assert.IsInstanceOfType(result, typeof(Airplane));
    }

    [TestMethod]
    public void CreateAirplane_ModelIsNotEmpty()
    {
        Airplane airplane = _factory.CreateAirplane();
        Assert.IsFalse(string.IsNullOrWhiteSpace(airplane.Model));
    }

    [TestMethod]
    public void CreateAirplane_CapacityInRange()
    {
        for (int i = 0; i < 20; i++)
        {
            Airplane airplane = _factory.CreateAirplane();
            Assert.IsTrue(airplane.Capacity >= 100 && airplane.Capacity < 300,
                $"Capacity={airplane.Capacity} вне диапазона [100, 300)");
        }
    }

    [TestMethod]
    public void CreateAirplane_RangeKmInRange()
    {
        for (int i = 0; i < 20; i++)
        {
            Airplane airplane = _factory.CreateAirplane();
            Assert.IsTrue(airplane.RangeKm >= 2000 && airplane.RangeKm < 8000,
                $"RangeKm={airplane.RangeKm} вне диапазона [2000, 8000)");
        }
    }

    // ─── Interface contract ──────────────────────────────────────────────────

    [TestMethod]
    public void RandomFactory_ImplementsAbstractFactory()
    {
        Assert.IsInstanceOfType(_factory, typeof(AbstractFactory));
    }
}
using OOP_laba3.classes;

namespace OOP_laba3.services;

public class RandomAbstractFactory : AbstractFactory
{
    private static readonly string[] Names = 
        { "Шереметьево", "Домодедово", "Внуково", "Пулково", "Кольцово" };
    
    private static readonly string[] Locations = 
        { "Москва", "Санкт-Петербург", "Екатеринбург", "Казань", "Новосибирск" };
    
    private static readonly string[] AirplaneModels =
        { "Boeing 737", "Airbus A320", "Superjet 100" };

    private static readonly string[] Positions =
        { "Пилот", "Диспетчер", "Инженер" };

    private readonly Random _random = new Random();

    public Airport CreateAirport()
    {
        return new Airport(
            name: Names[_random.Next(Names.Length)],
            location: Locations[_random.Next(Locations.Length)],
            flightsPerDay: _random.Next(10, 200),
            ticketsSold: _random.Next(100, 5000),
            balance: (decimal)(_random.NextDouble() * 1_000_000),
            rating: Math.Round(_random.NextDouble() * 5, 1),
            employeesCount: _random.Next(50, 2000)
        );
    }

    public Airplane CreateAirplane()
    {
        return new Airplane(
            AirplaneModels[_random.Next(AirplaneModels.Length)],
            _random.Next(100, 300),
            _random.Next(2000, 8000)
        );
    }
    
}
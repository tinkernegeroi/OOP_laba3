using OOP_laba3.classes;

namespace OOP_laba3.services;

/// <summary>
/// Конкретная реализация <see cref="AbstractFactory"/>, генерирующая
/// премиум-объекты аэропортов и самолётов с высокими характеристиками.
/// </summary>
public class PremiumAbstractFactory : AbstractFactory
{
    /// <summary>Набор названий для премиум-аэропортов.</summary>
    private static readonly string[] AirportNames =
        { "VIP International", "Elite Sky Hub", "Royal AirPort", "Platinum Wings" };

    /// <summary>Набор премиум-локаций аэропортов.</summary>
    private static readonly string[] Locations =
        { "Дубай", "Сингапур", "Монако", "Цюрих" };

    /// <summary>Набор моделей самолётов бизнес- и люкс-класса.</summary>
    private static readonly string[] AirplaneModels =
        { "Boeing 787 Dreamliner", "Airbus A350", "Gulfstream G700", "Bombardier Global 8000" };

    /// <summary>Набор должностей для персонала премиум-аэропортов.</summary>
    private static readonly string[] Positions =
        { "Главный пилот", "VIP Диспетчер", "Авиаконструктор", "Технический директор" };

    private readonly Random _random = new Random();

    /// <summary>
    /// Создаёт премиум-аэропорт со случайными, но заведомо высокими показателями.
    /// </summary>
    /// <returns>Экземпляр <see cref="Airport"/> с характеристиками премиум-класса.</returns>
    public Airport CreateAirport()
    {
        return new Airport(
            name: AirportNames[_random.Next(AirportNames.Length)],
            location: Locations[_random.Next(Locations.Length)],
            flightsPerDay: _random.Next(300, 800),
            ticketsSold: _random.Next(5000, 20000),
            balance: (decimal)(_random.NextDouble() * 100_000_000 + 10_000_000),
            rating: Math.Round(4.5 + _random.NextDouble() * 0.5, 1),
            employeesCount: _random.Next(2000, 10000)
        );
    }

    /// <summary>
    /// Создаёт дальнемагистральный самолёт бизнес-класса со случайными характеристиками.
    /// </summary>
    /// <returns>Экземпляр <see cref="Airplane"/> с характеристиками премиум-класса.</returns>
    public Airplane CreateAirplane()
    {
        return new Airplane(
            model: AirplaneModels[_random.Next(AirplaneModels.Length)],
            capacity: _random.Next(250, 500),
            rangeKm: _random.Next(10_000, 18_000)
        );
    }
}
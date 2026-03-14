using OOP_laba3.classes;

namespace OOP_laba3.services;

/// <summary>
/// Конкретная реализация <see cref="AbstractFactory"/>, генерирующая
/// стандартные объекты аэропортов и самолётов со случайными характеристиками.
/// </summary>
public class RandomAbstractFactory : AbstractFactory
{
    /// <summary>Набор названий российских аэропортов.</summary>
    private static readonly string[] Names =
        { "Шереметьево", "Домодедово", "Внуково", "Пулково", "Кольцово" };

    /// <summary>Набор городов расположения аэропортов.</summary>
    private static readonly string[] Locations =
        { "Москва", "Санкт-Петербург", "Екатеринбург", "Казань", "Новосибирск" };

    /// <summary>Набор моделей самолётов эконом- и среднего класса.</summary>
    private static readonly string[] AirplaneModels =
        { "Boeing 737", "Airbus A320", "Superjet 100" };

    /// <summary>Набор должностей сотрудников аэропорта.</summary>
    private static readonly string[] Positions =
        { "Пилот", "Диспетчер", "Инженер" };

    private readonly Random _random = new Random();

    /// <summary>
    /// Создаёт стандартный аэропорт со случайными характеристиками в пределах типичных значений.
    /// </summary>
    /// <returns>Экземпляр <see cref="Airport"/> с обычными характеристиками.</returns>
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

    /// <summary>
    /// Создаёт стандартный самолёт со случайными характеристиками.
    /// </summary>
    /// <returns>Экземпляр <see cref="Airplane"/> с обычными характеристиками.</returns>
    public Airplane CreateAirplane()
    {
        return new Airplane(
            AirplaneModels[_random.Next(AirplaneModels.Length)],
            _random.Next(100, 300),
            _random.Next(2000, 8000)
        );
    }
}
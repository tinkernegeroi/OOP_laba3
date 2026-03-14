namespace OOP_laba3.classes;

/// <summary>
/// Представляет воздушное судно с основными характеристиками.
/// </summary>
public class Airplane
{
    /// <summary>Модель самолёта (например, "Boeing 737").</summary>
    public string Model { get; set; }

    /// <summary>Максимальное количество пассажиров на борту.</summary>
    public int Capacity { get; set; }

    /// <summary>Максимальная дальность полёта в километрах.</summary>
    public double RangeKm { get; set; }

    /// <summary>
    /// Инициализирует новый экземпляр <see cref="Airplane"/>.
    /// </summary>
    /// <param name="model">Модель самолёта.</param>
    /// <param name="capacity">Вместимость (количество пассажиров).</param>
    /// <param name="rangeKm">Дальность полёта в км.</param>
    public Airplane(string model, int capacity, double rangeKm)
    {
        Model = model;
        Capacity = capacity;
        RangeKm = rangeKm;
    }

    /// <summary>
    /// Возвращает строковое представление самолёта.
    /// </summary>
    public override string ToString()
    {
        return $"Самолет: {Model}, Вместимость: {Capacity}, Дальность: {RangeKm} км";
    }
}
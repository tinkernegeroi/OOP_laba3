using System.Diagnostics;
using OOP_laba3.classes;

namespace OOP_laba3.services;

/// <summary>
/// Утилита для сравнительного измерения производительности операций
/// над <see cref="List{T}"/> и массивом для типа <see cref="Airport"/>.
/// </summary>
public class PerformanceMeter
{
    private static Stopwatch stopwatch = new Stopwatch();
    private static Random rnd = new Random();
    private static AbstractFactory _generator = new RandomAbstractFactory();

    /// <summary>Количество элементов, используемых во всех тестах.</summary>
    private const int size = 100_000;

    /// <summary>Коллекция-список, используемая в замерах.</summary>
    public static AirportCollection collection = new AirportCollection();

    /// <summary>Массив, используемый в замерах.</summary>
    public static Airport[] array = new Airport[size];

    /// <summary>
    /// Измеряет время последовательной вставки <c>size</c> элементов в список.
    /// </summary>
    /// <returns>Время выполнения в миллисекундах.</returns>
    public static int InsertIntoList()
    {
        collection.List.Clear();
        stopwatch.Reset();
        stopwatch.Start();
        for (int i = 0; i < size; i++) collection.AddRandomItem();
        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }

    /// <summary>
    /// Измеряет время последовательной вставки <c>size</c> элементов в массив.
    /// </summary>
    /// <returns>Время выполнения в миллисекундах.</returns>
    public static int InsertIntoArray()
    {
        array = new Airport[size];
        stopwatch.Reset();
        stopwatch.Start();
        for (int i = 0; i < size; i++) array[i] = _generator.CreateAirport();
        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }

    /// <summary>
    /// Измеряет время последовательного чтения всех элементов списка по индексу.
    /// </summary>
    /// <returns>Время выполнения в миллисекундах.</returns>
    public static int MeasureListSequentialRead()
    {
        stopwatch.Reset();
        stopwatch.Start();
        for (int i = 0; i < collection.GetItemCount(); i++) { var _ = collection.List[i]; }
        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }

    /// <summary>
    /// Измеряет время последовательного чтения всех элементов массива по индексу.
    /// </summary>
    /// <returns>Время выполнения в миллисекундах.</returns>
    public static int MeasureArraySequentialRead()
    {
        stopwatch.Reset();
        stopwatch.Start();
        for (int i = 0; i < array.Length; i++) { var _ = array[i]; }
        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }

    /// <summary>
    /// Измеряет время случайного чтения <c>size</c> элементов из списка
    /// по заранее сгенерированному набору случайных индексов.
    /// </summary>
    /// <returns>Время выполнения в миллисекундах.</returns>
    public static int MeasureListRandomRead()
    {
        var indices = Enumerable.Range(0, size).Select(_ => rnd.Next(size)).ToArray();
        stopwatch.Restart();
        foreach (var i in indices) { var _ = collection.List[i]; }
        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }

    /// <summary>
    /// Измеряет время случайного чтения <c>size</c> элементов из массива
    /// по заранее сгенерированному набору случайных индексов.
    /// </summary>
    /// <returns>Время выполнения в миллисекундах.</returns>
    public static int MeasureArrayRandomRead()
    {
        var indices = Enumerable.Range(0, size).Select(_ => rnd.Next(size)).ToArray();
        stopwatch.Restart();
        foreach (var i in indices) { var _ = array[i]; }
        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }
}
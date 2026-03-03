using System.Diagnostics;
using OOP_laba3.classes;

namespace OOP_laba3.services;

public class PerformanceMeter
{
    private static Stopwatch stopwatch = new Stopwatch();
    private static Random rnd = new Random();
    private static RandomAbstractFactory _generator = new RandomAbstractFactory();

    private const int size = 100_000;
    
    public static AirportCollection collection = new AirportCollection();
    
    public static Airport[] array = new Airport[size];

    public static int InsertIntoList()
    {
        collection.List.Clear();
        stopwatch.Reset();
        stopwatch.Start();
        for (int i = 0; i < size; i++) collection.AddRandomItem();
        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }

    public static int InsertIntoArray()
    {
        array =  new Airport[size];
        stopwatch.Reset();
        stopwatch.Start();
        for (int i = 0; i < size; i++) array[i] = _generator.CreateAirport();
        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }

    public static int MeasureListSequentialRead()
    {
        stopwatch.Reset();
        stopwatch.Start();
        for (int i = 0; i < collection.GetItemCount(); i++) { var _ = collection.List[i]; }
        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }

    public static int MeasureArraySequentialRead()
    {
        stopwatch.Reset();
        stopwatch.Start();
        for (int i = 0; i < array.Length; i++) { var _ = array[i]; }
        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }

    public static int MeasureListRandomRead()
    {
        var indices = Enumerable.Range(0, size).Select(_ => rnd.Next(size)).ToArray();
        stopwatch.Restart();
        foreach (var i in indices) { var _ = collection.List[i]; }
        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }
    
    public static int MeasureArrayRandomRead()
    {
        var indices = Enumerable.Range(0, size).Select(_ => rnd.Next(size)).ToArray();
        stopwatch.Restart();
        foreach (var i in indices) { var _ = array[i]; }
        stopwatch.Stop();
        return (int)stopwatch.ElapsedMilliseconds;
    }
}
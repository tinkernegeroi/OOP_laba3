namespace OOP_laba3.classes;

public class Airplane
{
    public string Model { get; set; }
    public int Capacity { get; set; }
    public double RangeKm { get; set; }

    public Airplane(string model, int capacity, double rangeKm)
    {
        Model = model;
        Capacity = capacity;
        RangeKm = rangeKm;
    }

    public override string ToString()
    {
        return $"Самолет: {Model}, Вместимость: {Capacity}, Дальность: {RangeKm} км";
    }
}
using OOP_laba3.services;

namespace OOP_laba3.classes;

/// <summary>
/// Делегат для обработки событий изменения коллекции аэропортов.
/// </summary>
/// <param name="msg">Сообщение, описывающее произошедшее изменение.</param>
public delegate void ListChanged(string msg);

/// <summary>
/// Управляемая коллекция аэропортов с поддержкой событий добавления и удаления,
/// а также генерации случайных элементов через фабрики.
/// </summary>
public class AirportCollection
{
    /// <summary>Внутренний список аэропортов.</summary>
    public List<Airport> List;

    /// <summary>Фабрика для создания обычных случайных аэропортов.</summary>
    private readonly AbstractFactory _randomGenerator = new RandomAbstractFactory();

    /// <summary>Фабрика для создания премиум-аэропортов.</summary>
    private readonly AbstractFactory _randomPremiumGenerator = new PremiumAbstractFactory();

    /// <summary>
    /// Возникает при успешном добавлении аэропорта в коллекцию.
    /// </summary>
    public event ListChanged ItemAdded;

    /// <summary>
    /// Возникает при успешном удалении аэропорта из коллекции.
    /// </summary>
    public event ListChanged ItemRemoved;

    /// <summary>
    /// Инициализирует пустую коллекцию аэропортов.
    /// </summary>
    public AirportCollection()
    {
        List = new List<Airport>();
    }

    /// <summary>
    /// Добавляет аэропорт в коллекцию и вызывает событие <see cref="ItemAdded"/>.
    /// </summary>
    /// <param name="airport">Аэропорт для добавления.</param>
    public void Add(Airport airport)
    {
        List.Add(airport);
        ItemAdded?.Invoke($"Элемент с названием {airport.Name} добавлен" + Environment.NewLine);
    }

    /// <summary>
    /// Удаляет аэропорт по индексу и вызывает событие <see cref="ItemRemoved"/>.
    /// </summary>
    /// <param name="index">Индекс удаляемого элемента.</param>
    /// <exception cref="IndexOutOfRangeException">
    /// Выбрасывается, если индекс выходит за пределы коллекции.
    /// </exception>
    public void Remove(int index)
    {
        if (index >= 0 && index < List.Count)
        {
            List.RemoveAt(index);
            ItemRemoved?.Invoke($"Элемент с индексом {index} удален" + Environment.NewLine);
        }
        else
        {
            throw new IndexOutOfRangeException();
        }
    }

    /// <summary>
    /// Добавляет случайно сгенерированный обычный аэропорт в коллекцию.
    /// </summary>
    public void AddRandomItem()
    {
        Add(_randomGenerator.CreateAirport());
    }

    /// <summary>
    /// Добавляет случайно сгенерированный премиум-аэропорт в коллекцию.
    /// </summary>
    public void AddRandomPremiumItem()
    {
        Add(_randomPremiumGenerator.CreateAirport());
    }

    /// <summary>
    /// Возвращает текущее количество элементов в коллекции.
    /// </summary>
    /// <returns>Число аэропортов в списке.</returns>
    public int GetItemCount()
    {
        return List.Count;
    }
}
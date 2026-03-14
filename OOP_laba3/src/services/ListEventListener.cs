using OOP_laba3.classes;

namespace OOP_laba3.services;

/// <summary>
/// Подписывается на события изменения <see cref="AirportCollection"/>
/// и отображает уведомления в указанном текстовом поле.
/// </summary>
public class ListEventListener
{
    /// <summary>Текстовое поле, в которое выводятся сообщения о событиях.</summary>
    private TextBox _textBox;

    /// <summary>
    /// Инициализирует слушатель и подписывается на события коллекции.
    /// </summary>
    /// <param name="list">Коллекция аэропортов, события которой нужно отслеживать.</param>
    /// <param name="textBox">Элемент управления для вывода сообщений.</param>
    public ListEventListener(AirportCollection list, TextBox textBox)
    {
        this._textBox = textBox;
        list.ItemAdded += (message) => { this._textBox.Text += message; };
        list.ItemRemoved += (message) => { this._textBox.Text += message; };
    }
}
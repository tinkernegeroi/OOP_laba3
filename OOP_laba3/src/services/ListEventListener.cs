using OOP_laba3.classes;

namespace OOP_laba3.services;

public class ListEventListener
{
    private TextBox _textBox;

    public ListEventListener(AirportCollection list, TextBox textBox)
    {
        this._textBox = textBox;
        list.ItemAdded += (message) => { this._textBox.Text += message; };
        list.ItemRemoved += (message) => { this._textBox.Text += message; };
    }
}
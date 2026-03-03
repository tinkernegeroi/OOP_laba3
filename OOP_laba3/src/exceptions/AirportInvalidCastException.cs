using System;

namespace OOP_laba3.exceptions;

public class AirportInvalidCastException : Exception
{
    public AirportInvalidCastException() 
        : base("Ошибка приведения типа.") { }

    public AirportInvalidCastException(string message) 
        : base(message) { }
}
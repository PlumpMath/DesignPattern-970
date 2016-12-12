using System;

public class ParseException : Exception
{
    public ParseException() : base()
    {
    }

    public ParseException(string msg) : base(msg)
    {
    }
}

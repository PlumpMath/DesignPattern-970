using System;

public class FileTreatmentException : Exception
{
    public FileTreatmentException()
    {
    }

    public FileTreatmentException(string message)
        : base(message)
    {
    }

    public FileTreatmentException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

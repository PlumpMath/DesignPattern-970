using System;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
            Environment.Exit(0);

        BigString bs = new BigString(args[0]);
        bs.Print();
    }
}

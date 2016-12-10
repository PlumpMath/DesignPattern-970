using System.Threading;

public class Printer : Printable
{
    private string name;

    public Printer()
    {
        HeavyJob("Creating Instance...");
    }

    public Printer(string name)
    {
        this.name = name;
        HeavyJob("Creating Instance (" + name + ")...");
    }

    public void SetPrinterName(string name)
    {
        this.name = name;
    }

    public string GetPrinterName()
    {
        return name;
    }

    public void Print(string str)
    {
        System.Console.WriteLine("=== " + name + " ===");
        System.Console.WriteLine(str);
    }

    private void HeavyJob(string msg)
    {
        System.Console.Write(msg);
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(1000);
        }
        System.Console.WriteLine("done.");
    }
}

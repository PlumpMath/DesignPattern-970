public class Program
{
    public static void Main(string[] args)
    {
        Printable p = new PrinterProxy("Alice");
        System.Console.WriteLine("Name is " + p.GetPrinterName() + " now");

        p.SetPrinterName("Bob");
        System.Console.WriteLine("Name is " + p.GetPrinterName() + " now");

        p.Print("Hello, world");
    }
}

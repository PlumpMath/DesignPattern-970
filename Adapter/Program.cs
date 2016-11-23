public class Program
{
    public static void Main(string[] args)
    {
        Print p = new PrintBanner("Hello");
        p.PrintWeak();
        p.PrintStrong();
    }
}

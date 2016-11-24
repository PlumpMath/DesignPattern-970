public class Program
{
    public static void Main(string[] args)
    {
        Display d1 = new StringDisplay("Hello, world.");
        Display d2 = new SideBorder(d1, '#');
        Display d3 = new FullBorder(d2);

        d1.Show();
        d2.Show();
        d3.Show();

        Display d4 = new FullBorder(d3);
        d4.Show();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        AbstractDisplay d1 = new CharDisplay('H');
        AbstractDisplay d2 = new StringDisplay("Hello, world");

        d1.display();
        d2.display();
    }
}

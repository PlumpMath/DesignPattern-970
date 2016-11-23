using Framework;
using IdCard;

public class Program
{
    public static void Main(string[] args)
    {
        Factory factory = new IdCardFactory();

        Product card1 = factory.Create("Andy");
        Product card2 = factory.Create("Bob");
        Product card3 = factory.Create("Charlie");

        card1.Use();
        card2.Use();
        card3.Use();
    }
}

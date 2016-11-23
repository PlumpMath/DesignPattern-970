public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Start");

        Singleton obj1 = Singleton.GetInstance();
        Singleton obj2 = Singleton.GetInstance();

        if (obj1 == obj2)
            System.Console.WriteLine("obj1 and obj2 are same Instance");
        else
            System.Console.WriteLine("obj1 and obj2 are not same Instance");

        System.Console.WriteLine("End");
    }
}

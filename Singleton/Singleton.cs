public class Singleton
{
    private static Singleton singleton = new Singleton();

    private Singleton()
    {
        System.Console.WriteLine("Create Instnce");
    }

    public static Singleton GetInstance()
    {
        return singleton;
    }
}

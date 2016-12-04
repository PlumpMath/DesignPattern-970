using System.Threading;

public class GraphObserver : Observer
{
    public void Update(NumberGenerator generator)
    {
        int count = generator.GetNumber();
        for (int i = 0; i < count; i++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine("");
        Thread.Sleep(100);
    }
}

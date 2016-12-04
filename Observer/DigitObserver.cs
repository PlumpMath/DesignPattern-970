using System.Threading;

public class DigitObserver : Observer
{
    public void Update(NumberGenerator generator)
    {
        System.Console.WriteLine("DigitObserver:" + generator.GetNumber());
        Thread.Sleep(100);
    }
}

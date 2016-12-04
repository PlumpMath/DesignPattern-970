using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        Gamer gamer = new Gamer(100);
        Memento memento = gamer.CreateMemento();

        for (int i = 0; i < 100; i++)
        {
            System.Console.WriteLine("==== " + i);
            System.Console.WriteLine("Current Status:" + gamer);

            gamer.Bet();
            System.Console.WriteLine("Money has reached " + gamer.GetMoney());

            if (gamer.GetMoney() > memento.GetMoney())
            {
                System.Console.WriteLine("Money increased a lot, so save it");
                memento = gamer.CreateMemento();
            }
            else if (gamer.GetMoney() < memento.GetMoney() / 2)
            {
                System.Console.WriteLine("Money reduced a lot, so load it");
                gamer.RestoreMemento(memento);
            }

            Thread.Sleep(1000);
        }
    }
}

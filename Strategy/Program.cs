using System;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length != 2)
            Environment.Exit(0);

        int seed1 = Int32.Parse(args[0]);
        int seed2 = Int32.Parse(args[1]);

        Player player1 = new Player("Andy", new WinningStrategy(seed1));
        Player player2 = new Player("Bob", new ProbStrategy(seed2));

        for (int i = 0; i < 100; i++)
        {
            Hand nextHand1 = player1.NextHand();
            Hand nextHand2 = player2.NextHand();

            if (nextHand1.IsStrongerThan(nextHand2))
            {
                System.Console.WriteLine("Winner:" + player1);
                player1.Win();
                player2.Lose();
            }
            else if (nextHand2.IsStrongerThan(nextHand1))
            {
                System.Console.WriteLine("Winner:" + player2);
                player1.Lose();
                player2.Win();
            }
            else
            {
                System.Console.WriteLine("Even...");
                player1.Even();
                player2.Even();
            }
        }

        System.Console.WriteLine("Total result:");
        System.Console.WriteLine(player1.ToString());
        System.Console.WriteLine(player2.ToString());
    }
}

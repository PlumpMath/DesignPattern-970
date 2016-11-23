using System;

public class ProbStrategy : IStrategy
{
    private Random random;

    private int prevHandValue = 0;
    private int currentHandValue = 0;

    private static readonly int[] p = { 1, 1, 1 };
    private int[][] history =
    {
        p,
        p,
        p
    };

    public ProbStrategy(int seed)
    {
        random = new Random(seed);
    }

    public Hand NextHand()
    {
        int bet = random.Next(GetSum(currentHandValue));
        int handValue = 0;
        if (bet < history[currentHandValue][0])
            handValue = 0;
        else if (bet < history[currentHandValue][0] + history[currentHandValue][1])
            handValue = 1;
        else
            handValue = 2;

        prevHandValue = currentHandValue;
        currentHandValue = handValue;

        return Hand.GetHand(handValue);
    }

    public void Study(bool IsWin)
    {
        if (IsWin)
        {
            history[prevHandValue][currentHandValue]++;
            return;
        }

        history[prevHandValue][(currentHandValue + 1) % 3]++;
        history[prevHandValue][(currentHandValue + 2) % 3]++;
    }

    private int GetSum(int hv)
    {
        int sum = 0;
        for (int i = 0; i < 3; i++)
        {
            sum += history[hv][i];
        }

        return sum;
    }
}

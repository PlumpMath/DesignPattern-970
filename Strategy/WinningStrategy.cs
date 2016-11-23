using System;

public class WinningStrategy : IStrategy
{
    private Random random;
    private bool IsWon = false;

    private Hand PrevHand;

    public WinningStrategy(int seed)
    {
        random = new Random(seed);
    }

    public Hand NextHand()
    {
        if (!IsWon)
            PrevHand = Hand.GetHand(random.Next(3));

        return PrevHand;
    }

    public void Study(bool IsWin)
    {
        IsWon = IsWin;
    }
}

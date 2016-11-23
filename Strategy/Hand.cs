public class Hand
{
    public static readonly int HandValueGuu = 0;
    public static readonly int HandValueCho = 1;
    public static readonly int HandValuePaa = 2;

    public static readonly Hand[] hand =
    {
        new Hand(HandValueGuu),
        new Hand(HandValueCho),
        new Hand(HandValuePaa),
    };

    private static readonly string[] name =
    {
        "グー",
        "チョキ",
        "パー",
    };

    private int handValue;

    private Hand(int handValue)
    {
        this.handValue = handValue;
    }

    public static Hand GetHand(int handValue)
    {
        return hand[handValue];
    }

    public bool IsStrongerThan(Hand hand)
    {
        return Fight(hand) == 1;
    }

    private int Fight(Hand hand)
    {
        if (this == hand)
            return 0;
        if ((this.handValue + 1) % 3 == hand.handValue)
            return 1;

        return -1;
    }

    public override string ToString()
    {
        return name[handValue];
    }
}

public interface IStrategy
{
    Hand NextHand();
    void Study(bool IsWin);
}

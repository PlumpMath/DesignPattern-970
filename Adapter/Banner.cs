public class Banner
{
    private string str;

    public Banner(string str)
    {
        this.str = str;
    }

    public void ShowWithParen()
    {
        System.Console.WriteLine("(" + str + ")");
    }

    public void ShowWithAster()
    {
        System.Console.WriteLine("*" + str + "*");
    }
}

public class StringDisplay : AbstractDisplay
{
    private string str;
    private int width;

    public StringDisplay(string str)
    {
        this.str = str;
        this.width = str.Length;
    }

    public override void Open()
    {
        PrintLine();
    }

    public override void Print()
    {
        System.Console.WriteLine("|" + str + "|");
    }

    public override void Close()
    {
        PrintLine();
    }

    private void PrintLine()
    {
        System.Console.Write("+");
        for (int i = 0; i < width; i++)
        {
            System.Console.Write("-");
        }
        System.Console.WriteLine("+");
    }
}

public class StringDisplayImpl : DisplayImpl
{
    private string str;
    private int width;

    public StringDisplayImpl(string str)
    {
        this.str = str;
        this.width = str.Length;
    }

    public override void RawOpen()
    {
        PrintLine();
    }
    public override void RawPrint()
    {
        System.Console.WriteLine("|" + str + "|");
    }

    public override void RawClose()
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

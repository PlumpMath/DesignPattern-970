public class CharDisplay : AbstractDisplay
{
    private char ch;

    public CharDisplay(char ch)
    {
        this.ch = ch;
    }

    public override void Open()
    {
        System.Console.Write("<<");
    }

    public override void Print()
    {
        System.Console.Write(ch);
    }

    public override void Close()
    {
        System.Console.WriteLine(">>");
    }
}

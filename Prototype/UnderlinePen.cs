using Framework;

public class UnderlinePen : IProduct
{
    private char ulchar;

    public UnderlinePen(char ulchar)
    {
        this.ulchar = ulchar;
    }

    public void Use(string str)
    {
        int length = str.Length;

        System.Console.WriteLine("\"" + str + "\"");
        System.Console.Write(" ");
        for (int i = 0; i < length; i++)
        {
            System.Console.Write(ulchar);
        }
        System.Console.WriteLine("");
    }

    public IProduct Clone()
    {
        return base.MemberwiseClone() as IProduct;
    }
}

using Framework;

public class MessageBox : IProduct
{
    private char decochar;

    public MessageBox(char decochar)
    {
        this.decochar = decochar;
    }

    public void Use(string str)
    {
        int length = str.Length;
        for (int i = 0; i < length + 4; i++)
        {
            System.Console.Write(decochar);
        }

        System.Console.WriteLine("");
        System.Console.WriteLine(decochar + " " + str + " " + decochar);

        for (int i = 0; i < length + 4; i++)
        {
            System.Console.Write(decochar);
        }
        System.Console.WriteLine("");
    }

    public IProduct Clone()
    {
        return base.MemberwiseClone() as IProduct;
    }
}

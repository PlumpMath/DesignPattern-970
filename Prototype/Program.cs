using Framework;


public class Program
{
    public static void Main(string[] args)
    {
        Manager manager = new Manager();

        UnderlinePen upen = new UnderlinePen('~');
        MessageBox mbox = new MessageBox('*');
        MessageBox sbox = new MessageBox('/');
        manager.Register("strong message", upen);
        manager.Register("warning box", mbox);
        manager.Register("slash box", sbox);


        IProduct p1 = manager.Clone("strong message");
        p1.Use("Hello");
        IProduct p2 = manager.Clone("warning box");
        p2.Use("Hello");
        IProduct p3 = manager.Clone("slash box");
        p3.Use("Hello");
    }
}

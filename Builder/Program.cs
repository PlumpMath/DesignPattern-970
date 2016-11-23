public class Program
{
    public static void Main(string[] args)
    {
        if (args[0].Equals("plain"))
        {
            TextBuilder textBuilder = new TextBuilder();
            Director director = new Director(textBuilder);
            director.Construct();
            System.Console.WriteLine(textBuilder.GetResult());
        }

        if (args[0].Equals("html"))
        {
            HtmlBuilder htmlBuilder = new HtmlBuilder();
            Director director = new Director(htmlBuilder);
            director.Construct();
            System.Console.WriteLine(htmlBuilder.GetResult());
        }
    }
}

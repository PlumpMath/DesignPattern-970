using AbstractFactory;

public class Program
{
    public static void Main(string[] args)
    {
        Factory factory = Factory.GetFactory(args[0]);

        Link jpGoogle = factory.CreateLink("google-jp", "https://www.google.co.jp");
        Link jpYahoo = factory.CreateLink("yahoo-jp", "http://www.yahoo.co.jp");

        Link usGoogle = factory.CreateLink("google-us", "https://www.google.com");
        Link usYahoo = factory.CreateLink("yahoo-us", "http://www.yahoo.com");

        Tray trayGoogle = factory.CreateTray("Google");
        trayGoogle.Add(jpGoogle);
        trayGoogle.Add(usGoogle);

        Tray trayYahoo = factory.CreateTray("Yahoo");
        trayYahoo.Add(jpYahoo);
        trayYahoo.Add(usYahoo);

        Tray traySearch = factory.CreateTray("Search Engine");
        traySearch.Add(trayGoogle);
        traySearch.Add(trayYahoo);

        Page page = factory.CreatePage("LinkPage", "John Smith");
        page.Add(traySearch);
        page.OutPut();
    }
}

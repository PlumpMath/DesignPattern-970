public class PrintBanner : Print
{
    private Banner banner;

    public PrintBanner(string str)
    {
        this.banner = new Banner(str);
    }

    public override void PrintWeak()
    {
        banner.ShowWithParen();
    }

    public override void PrintStrong()
    {
        banner.ShowWithAster();
    }
}

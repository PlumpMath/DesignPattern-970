using System.IO;

public class HtmlWriter
{
    private StreamWriter sw;

    public HtmlWriter(StreamWriter sw)
    {
        this.sw = sw;
    }

    public void Title(string title)
    {
        sw.Write("<html>\n");
        sw.Write("<head>\n");
        sw.Write("<title>" + title + "</title>\n");
        sw.Write("</head>\n");
        sw.Write("<body>\n");
        sw.Write("<h1>" + title + "</h>\n");
    }

    public void Paragraph(string msg)
    {
        sw.Write("<p>" + msg + "</p>\n");
    }

    public void Link(string href, string caption)
    {
        Paragraph("<a href=\"" + href + "\">" + caption + "</a>");
    }

    public void MailTo(string mailAddr, string name)
    {
        Link("mailto:" + mailAddr, name);
    }

    public void Close()
    {
        sw.Write("</body>\n");
        sw.Write("</html>\n");
    }
}

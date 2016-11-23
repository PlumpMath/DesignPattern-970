using System.Text;

public class HtmlBuilder : Builder
{
    private StringBuilder builder = new StringBuilder();

    public override void Close()
    {
        builder.Append("</body>\n</html>\n");
    }

    public override void MakeItems(string[] items)
    {
        builder.Append("<ul>\n");
        foreach (var item in items)
            builder.Append("<li>" + item + "</li>\n");

        builder.Append("</ul>\n");
    }

    public override void MakeString(string str)
    {
        builder.Append("<p>" + str + "</p>\n");
    }

    public override void MakeTitle(string title)
    {
        builder.Append("<html>\n<head>\n<title>" + title + "</title>\n</head>\n<body>\n");
        builder.Append("<h1>" + title + "</h1>\n");
    }

    public string GetResult()
    {
        return builder.ToString();
    }
}

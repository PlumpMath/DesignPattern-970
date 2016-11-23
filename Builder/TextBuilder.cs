using System.Text;

public class TextBuilder : Builder
{
    private StringBuilder builder = new StringBuilder();

    public override void Close()
    {
        builder.Append("==================================\n");
    }

    public override void MakeItems(string[] items)
    {
        foreach (var item in items)
            builder.Append(" ." + item + "\n");

        builder.Append("\n");
    }

    public override void MakeString(string str)
    {
        builder.Append("■" + str + "\n");
        builder.Append("\n");
    }

    public override void MakeTitle(string title)
    {
        builder.Append("==================================\n");
        builder.Append("『" + title + "』\n");
        builder.Append("\n");
    }

    public string GetResult()
    {
        return builder.ToString();
    }
}

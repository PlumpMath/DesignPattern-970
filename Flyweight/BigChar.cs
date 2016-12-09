using System.IO;
using System.Text;

public class BigChar
{
    private char charname;
    private string fontdata;

    public BigChar(char charname)
    {
        this.charname = charname;
        this.fontdata = LoadFontData();
    }

    private string LoadFontData()
    {
        string fontdata = "";
        string filename = Path.Combine("bigchar", "big" + charname + ".txt");
        using (FileStream fs = new FileStream(@filename, FileMode.Open))
        using (StreamReader sr = new StreamReader(fs))
        {
            StringBuilder sb = new StringBuilder();
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                sb.Append(line);
                sb.Append("\n");
            }

            fontdata = sb.ToString();
        }

        return fontdata;
    }

    public void Print()
    {
        System.Console.WriteLine(fontdata);
    }
}

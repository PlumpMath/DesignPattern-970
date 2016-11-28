using System.Collections.Generic;
using System.IO;

public class Database
{
    private Database()
    {
    }

    public static Dictionary<string, string> GetProperties(string dbname)
    {
        string filename = dbname + ".csv";
        Dictionary<string, string> dict = new Dictionary<string, string>();

        using (FileStream fs = new FileStream(@filename, FileMode.Open))
        using (StreamReader sr = new StreamReader(fs))
        {
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                var strings = line.Split(',');
                dict.Add(strings[0], strings[1]);
            }
        }

        return dict;
    }
}

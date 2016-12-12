using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class StringTokenizer : IEnumerable
{
    private List<string> tokens;

    public StringTokenizer(string str)
    {
        tokens = str.Split(' ').ToList();
    }

    public IEnumerator GetEnumerator()
    {
        return tokens.GetEnumerator();
    }
}

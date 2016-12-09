using System.Collections.Generic;

public class BigCharFactory
{
    private Dictionary<char, BigChar> pool = new Dictionary<char, BigChar>();

    private static BigCharFactory instance = new BigCharFactory();
    private BigCharFactory()
    {
    }

    public static BigCharFactory GetInstance()
    {
        return instance;
    }

    public BigChar GetBigChar(char charname)
    {
        if (pool.ContainsKey(charname))
            return pool[charname];

        BigChar bc = new BigChar(charname);
        pool.Add(charname, bc);

        return bc;
    }
}

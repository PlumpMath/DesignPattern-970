using System;
using System.Collections;

public class Context
{
    private IEnumerator tokens;
    private string currentToken;

    public Context(string text)
    {
        tokens = new StringTokenizer(text).GetEnumerator();
        NextToken();
    }

    public string NextToken()
    {
        if (tokens.MoveNext())
            currentToken = (string)tokens.Current;
        else
            currentToken = null;

        return currentToken;
    }

    public string CurrentToken()
    {
        return currentToken;
    }

    public void SkipToken(string token)
    {
        if (!token.Equals(currentToken))
            throw new ParseException(
                "Warning: " + token + " is expected, but " + currentToken + " is found.");

        NextToken();
    }

    public int CurrentNumber()
    {
        int number = 0;
        try
        {
            number = int.Parse(currentToken);
        }
        catch (FormatException e)
        {
            throw new ParseException("Warning: " + e);
        }

        return number;
    }
}

public abstract class Support
{
    private string name;
    private Support next;

    public Support(string name)
    {
        this.name = name;
    }

    public Support SetNext(Support next)
    {
        this.next = next;
        return next;
    }

    public void DoSupport(Trouble trouble)
    {
        if (Resolve(trouble))
        {
            Done(trouble);
            return;
        }

        if (next != null)
        {
            next.DoSupport(trouble);
            return;
        }

        Fail(trouble);
    }

    protected abstract bool Resolve(Trouble trouble);

    protected void Done(Trouble trouble)
    {
        System.Console.WriteLine(trouble + " is resolved by " + this.name + ".");
    }

    protected void Fail(Trouble trouble)
    {
        System.Console.WriteLine(trouble + " cannot be resolved.");
    }
}

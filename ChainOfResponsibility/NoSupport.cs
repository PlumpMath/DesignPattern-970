public class NoSupport : Support
{
    public NoSupport(string name) : base(name)
    {
    }

    protected override bool Resolve(Trouble troubl)
    {
        return false;
    }
}

using System.Collections.Generic;
using System.Linq;

public class Directory : Entry
{
    private string name;
    private List<Entry> directory = new List<Entry>();

    public Directory(string name)
    {
        this.name = name;
    }

    public override string GetName()
    {
        return name;
    }

    public override int GetSize()
    {
        return directory.Select(entry => entry.GetSize()).Sum();
    }

    public override Entry Add(Entry entry)
    {
        directory.Add(entry);
        return this;
    }

    protected internal override void PrintList(string prefix)
    {
        System.Console.WriteLine(prefix + "/" + this);
        directory.ForEach(entry => entry.PrintList(prefix + "/" + name));
    }
}

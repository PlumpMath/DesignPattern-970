using System.Collections.Generic;

public abstract class Entry : Element
{
    public abstract void Accept(Visitor visitor);
    public abstract string GetName();
    public abstract int GetSize();

    public virtual Entry Add(Entry entry)
    {
        throw new FileTreatmentException();
    }

    public virtual IEnumerable<Entry> Iterator()
    {
        throw new FileTreatmentException();
    }

    public override string ToString()
    {
        return GetName() + " (" + GetSize() + ")";
    }
}

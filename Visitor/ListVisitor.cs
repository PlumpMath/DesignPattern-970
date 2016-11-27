public class ListVisitor : Visitor
{
    private string currnetDir = "";

    public override void Visit(File file)
    {
        System.Console.WriteLine(currnetDir + "/" + file);
    }

    public override void Visit(Directory dir)
    {
        System.Console.WriteLine(currnetDir + "/" + dir);

        string saveDir = currnetDir;
        currnetDir = currnetDir + "/" + dir.GetName();

        foreach (var entry in dir.Iterator())
        {
            entry.Accept(this);
        }

        currnetDir = saveDir;
    }
}

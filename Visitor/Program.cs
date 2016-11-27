using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Making root entries....");
            Directory rootDir = new Directory("root");
            Directory binDir = new Directory("bin");
            Directory tmpDir = new Directory("tmp");
            Directory usrDir = new Directory("usr");

            rootDir.Add(binDir);
            rootDir.Add(tmpDir);
            rootDir.Add(usrDir);

            binDir.Add(new File("vi", 10000));
            binDir.Add(new File("latex", 20000));

            rootDir.Accept(new ListVisitor());

            Console.WriteLine("");
            Console.WriteLine("Making user entries....");
            Directory andy = new Directory("andy");
            Directory bob = new Directory("bob");

            usrDir.Add(andy);
            andy.Add(new File("diary.html", 100));

            usrDir.Add(bob);
            bob.Add(new File("memo.tex", 300));
            bob.Add(new File("game.doc", 400));

            rootDir.Accept(new ListVisitor());
        }
        catch (FileTreatmentException e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }
}

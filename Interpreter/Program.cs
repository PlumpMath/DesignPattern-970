using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            string filename = "program.txt";
            using (FileStream fs = new FileStream(@filename, FileMode.Open))
            using (StreamReader sr = new StreamReader(fs))
            {
                string text = "";
                while ((text = sr.ReadLine()) != null)
                {
                    System.Console.WriteLine("text = \"" + text + "\"");
                    Node node = new ProgramNode();
                    node.Parse(new Context(text));
                    System.Console.WriteLine("node = " + node);
                }
            }
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.StackTrace);
        }
    }
}

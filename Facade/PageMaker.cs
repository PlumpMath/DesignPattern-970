using System.IO;

public class PageMaker
{
    private PageMaker()
    {
    }

    public static void MakeWelcomePage(string mailAddr, string filename)
    {
        try
        {
            var prop = Database.GetProperties("maildata");
            if (!prop.ContainsKey(mailAddr))
                return;

            string username = prop[mailAddr];

            using (FileStream fs = new FileStream(@filename, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                HtmlWriter writer = new HtmlWriter(sw);
                writer.Title("Welcome to " + username + "'s page!");
                writer.Paragraph("Welcome to " + username + "'s page");
                writer.Paragraph("Waiting for Mail");
                writer.MailTo(mailAddr, username);
                writer.Close();
            }
        }
        catch (IOException e)
        {
            System.Console.WriteLine(e.StackTrace);
        }
    }
}

using System.Text;
using AbstractFactory;

namespace ConcreateFactory
{
    public class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author)
        {
        }

        public override string MakeHtml()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<html>\n");
            builder.Append("<head>\n");
            builder.Append("<title>" + title + "</title>\n");
            builder.Append("</head>\n");
            builder.Append("<body>\n");
            builder.Append("<h1>" + title + "</h>\n");

            builder.Append("<ul>\n");
            this.content.ForEach(item => builder.Append(item.MakeHtml()));
            builder.Append("</ul>\n");

            builder.Append("<hr><address>" + author + "</address");
            builder.Append("</body></html\n>");

            return builder.ToString();
        }
    }
}

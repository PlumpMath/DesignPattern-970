using System.Text;
using AbstractFactory;

namespace ConcreateFactory
{
    public class ListTray : Tray
    {
        public ListTray(string caption) : base(caption)
        {
        }

        public override string MakeHtml()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<li>\n" + caption + "\n");
            builder.Append("<ul>\n");
            this.tray.ForEach(item => builder.Append(item.MakeHtml()));
            builder.Append("</ul>\n");
            builder.Append("</li>\n");

            return builder.ToString();
        }
    }
}

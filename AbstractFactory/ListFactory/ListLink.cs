using AbstractFactory;

namespace ConcreateFactory
{
    public class ListLink : Link
    {
        public ListLink(string caption, string url) : base(caption, url)
        {
        }

        public override string MakeHtml()
        {
            return "  <li><a href=" + url + ">" + caption + "</a></li>\n";
        }
    }
}

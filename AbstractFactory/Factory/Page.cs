using System;
using System.Collections.Generic;
using System.IO;

namespace AbstractFactory
{
    public abstract class Page
    {
        protected string title;
        protected string author;
        protected List<Item> content = new List<Item>();

        public Page(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void Add(Item item)
        {
            content.Add(item);
        }

        public void OutPut()
        {
            try
            {
                string filename = title + ".html";
                FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(this.MakeHtml());
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
            }
        }

        public abstract string MakeHtml();
    }
}

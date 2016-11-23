using System;

namespace AbstractFactory
{
    public abstract class Factory
    {
        public static Factory GetFactory(string className)
        {
            Factory factory = null;
            try
            {
                Type type = Type.GetType(className);
                factory = Activator.CreateInstance(type) as Factory;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return factory;
        }

        public abstract Link CreateLink(string caption, string url);
        public abstract Tray CreateTray(string caption);
        public abstract Page CreatePage(string title, string author);
    }
}

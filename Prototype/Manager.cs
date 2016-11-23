using System.Collections.Generic;

namespace Framework
{
    public class Manager
    {
        private Dictionary<string, IProduct> showcase = new Dictionary<string, IProduct>();

        public void Register(string name, IProduct proto)
        {
            showcase.Add(name, proto);
        }

        public IProduct Clone(string protoname)
        {
            IProduct p = showcase[protoname];
            return p.Clone();
        }
    }
}

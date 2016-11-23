using System.Collections.Generic;
using Framework;

namespace IdCard
{
    public class IdCardFactory : Factory
    {
        private List<string> owners = new List<string>();

        protected override Product CreateProduct(string owner)
        {
            return new IdCard(owner);
        }

        protected override void RegisterProduct(Product Product)
        {
            var p = (IdCard)Product;
            owners.Add(p.GetOwner());
        }

        public List<string> GetOwners()
        {
            return owners;
        }
    }
}

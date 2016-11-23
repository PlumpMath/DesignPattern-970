using Framework;

namespace IdCard
{
    public class IdCard : Product
    {
        private string owner;

        public IdCard(string owner)
        {
            System.Console.WriteLine("Create" + owner + "'s card");
            this.owner = owner;
        }

        public override void Use()
        {
            System.Console.WriteLine("Use" + owner + "'s card");
        }

        public string GetOwner()
        {
            return owner;
        }
    }
}

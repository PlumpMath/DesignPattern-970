namespace Framework
{
    public abstract class Factory
    {
        public Product Create(string owner)
        {
            Product p = CreateProduct(owner);
            return p;
        }

        protected abstract Product CreateProduct(string owner);
        protected abstract void RegisterProduct(Product product);
    }
}

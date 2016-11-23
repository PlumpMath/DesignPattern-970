namespace Framework
{
    public interface IProduct
    {
        void Use(string str);
        IProduct Clone();
    }
}

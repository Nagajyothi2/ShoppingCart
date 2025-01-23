namespace ShoppingCart12.Repository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        void Save();
    }
}

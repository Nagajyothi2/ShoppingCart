using ShoppingCart12.Models;

namespace ShoppingCart12.Repository
{
    public interface ICategoryRepository :IRepository<Category>
    {
        void Update(Category obj);
    }
}

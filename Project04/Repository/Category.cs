using Project04.Models;
namespace Project04.Repository
{
    public interface Category
    {
        ProductCategory Add(ProductCategory category);
        ProductCategory Update(ProductCategory category);
        ProductCategory Delete(String categoryid);
        ProductCategory Get(String categoryid);
        IEnumerable<ProductCategory> GetAll();
    }
}

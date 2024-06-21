using Project04.Models;

namespace Project04.Repository
{
    public class Categories : Category
    {
        private readonly Project4Context _context;

        public Categories(Project4Context context)
        {
            _context = context;
        }
        public ProductCategory Add(ProductCategory category)
        {
            _context.ProductCategories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public ProductCategory Delete(string categoryid)
        {
            throw new NotImplementedException();
        }

        public ProductCategory Get(string categoryid)
        {
            return _context.ProductCategories.Find(categoryid);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _context.ProductCategories;
        }

        public ProductCategory Update(ProductCategory category)
        {
           _context.Update(category);
            _context.SaveChanges ();
            return category;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project04.Models;
using X.PagedList;

namespace Project04.Controllers
{
    
    public class ProductController : Controller
    {
        Project4Context db = new Project4Context();
        public IActionResult Index(int? page)
        {
            int pageSize = 8;
            int pageNumber= page==null || page<0 ? 1 : page.Value;
            var lstproduct = db.Products.AsNoTracking().OrderBy(x => x.Name).Include(product => product.ProductImages);
            PagedList<Product> lst = new PagedList<Product>(lstproduct, pageNumber, pageSize);


            return View(lst);
        }

        public IActionResult ProductbyCategory (int categoryid, int?page)
        {
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstproduct = db.Products.AsNoTracking().Where(x=>x.ProductCategoryId==categoryid).OrderBy(x => x.Name).Include(product => product.ProductImages).ToList();
            PagedList<Product> lst = new PagedList<Product>(lstproduct, pageNumber, pageSize);
            ViewBag.categoryid = categoryid;
            return View(lst);
        }

        public IActionResult ProductDetails(int productid) 
        {
            var product = db.Products.Include(p => p.ProductImages).SingleOrDefault(p=>p.Id==productid);
            return View(product);
        }
    }
}

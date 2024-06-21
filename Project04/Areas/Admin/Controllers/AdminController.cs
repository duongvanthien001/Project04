using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project04.Models;
using System.ComponentModel.DataAnnotations;
using X.PagedList;

namespace Project04.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    //[Route("admin/admin")]
    public class AdminController : Controller
    {
        Project4Context db = new Project4Context();
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        //LIST PRODUCT

        [Route("productmanagement")]
        public IActionResult ProductManagement()
        {
            
            var lstproduct = db.Products.Include(product => product.ProductImages).ToList();
            


            return View(lstproduct);
        }

        //ADD PRODUCT

        [Route("addnewproduct")]
        [HttpGet]
        public IActionResult AddNewProduct()
        {
            ViewBag.ProductCategories = new SelectList(db.ProductCategories.ToList(), "Id", "Name");
            return View();
        }

        [Route("addnewproduct")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNewProduct(Product product)//, IFormFile photo ) 
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("productmanagement");
            }

            //var path = Path.Combine("/productsP4", photo.FileName);
            //using (FileStream stream = new FileStream(path, FileMode.Create))
            //{
            //    await photo.CopyToAsync(stream);
            //    stream.Close();
            //}
            //ProductImage image = new ProductImage();
            //image.Url = path;

            //db.ProductImages.Add(image);



            return View(product);
        }

        //SHOW LIST CATEGORY

        [Route("categorymanagement")]
        public IActionResult CategoryManagement()
        {
            var lstcategory = db.ProductCategories.ToList();
            return View(lstcategory);
        }

        //ADD CATEGORY
        [Route("addnewcategory")]
        [HttpGet]
        public IActionResult AddNewCategory()
        {
            return View();
        }

        [Route("addnewcategory")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNewCategory(ProductCategory productCategory)
        {
            if (ModelState.IsValid)
            {
                db.ProductCategories.Add(productCategory);
                db.SaveChanges();
                return RedirectToAction("categorymanagement");
            }
            return View();
        }

        //EDIT CATEGORY
        [Route("editcategory")]
        [HttpGet]
        public IActionResult EditCategory(int categoryid)
        {
            var cateGory = db.ProductCategories.Find(categoryid);
            return View(cateGory);
        }

        [Route("editcategory")]
        [HttpPost]
        public IActionResult EditCategory(ProductCategory cateGory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cateGory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("categorymanagement");
            }
            return View(cateGory);
            
        }

        //DELETE CATEGORY
        [Route("deletecategory")]
        [HttpGet]
        public IActionResult DeleteCategory(int categoryid)
        {
            var cateGory = db.ProductCategories.Where(x => x.Id == categoryid).FirstOrDefault();
            db.ProductCategories.Remove(cateGory);
            db.SaveChanges();
            return RedirectToAction("categorymanagement");
        }




        
    }
}

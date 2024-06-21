using Microsoft.AspNetCore.Mvc;
using Project04.Repository;

namespace Project04.ViewComponents
{
    public class ViewCategory : ViewComponent
    {
        private readonly Category _viewCategory;
        public ViewCategory(Category cateGory)
        {
            _viewCategory = cateGory;
        }

        public IViewComponentResult Invoke()
        {
            var viewCategory = _viewCategory.GetAll().OrderBy(x => x.Name);
            return View(viewCategory);
        }
    }
}

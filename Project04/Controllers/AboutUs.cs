using Microsoft.AspNetCore.Mvc;

namespace Project04.Controllers
{
    public class AboutUs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

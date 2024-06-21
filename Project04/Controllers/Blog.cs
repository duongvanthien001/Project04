using Microsoft.AspNetCore.Mvc;

namespace Project04.Controllers
{
    public class Blog : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

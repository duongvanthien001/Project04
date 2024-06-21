using Microsoft.AspNetCore.Mvc;

namespace Project04.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
    }
}

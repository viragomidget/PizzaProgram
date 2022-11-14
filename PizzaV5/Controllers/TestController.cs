using Microsoft.AspNetCore.Mvc;

namespace PizzaV5.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

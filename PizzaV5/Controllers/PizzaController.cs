using Microsoft.AspNetCore.Mvc;
using PizzaV5.Models;

namespace PizzaV5.Controllers
{
    public class PizzaController : Controller
    {

        public IActionResult Index()
        {

            PizzaModel pizzaModel = new PizzaModel();

            pizzaModel.Id = 1;
            pizzaModel.PizzaName = "Pepperoni";
            pizzaModel.PizzaSize = 18;
            pizzaModel.PizzaPrice = 19;

            return View(pizzaModel);
        }


    }
}

using Microsoft.AspNetCore.Mvc;
using PizzaV5.Models;

namespace PizzaV5.Controllers
{
    public class PizzaControllerStatic : Controller
    {
        public IActionResult Index()
        {

            //Create list which pulls in the PizzaModel/Class, and return pizzas, this can be used for a static menu

            List<PizzaModel> pizzas = new List<PizzaModel>();
            pizzas.Add(new PizzaModel(1, "Pepperoni", 12));
            pizzas.Add(new PizzaModel(2, "Hawiaan", 12));
            pizzas.Add(new PizzaModel(3, "Pepperoni", 12));
            pizzas.Add(new PizzaModel(4, "Pepperoni", 12));
            pizzas.Add(new PizzaModel(5, "Pepperoni", 12));
            pizzas.Add(new PizzaModel(6, "Pepperoni", 12));

            return View("Index",pizzas);
        }

    }
}

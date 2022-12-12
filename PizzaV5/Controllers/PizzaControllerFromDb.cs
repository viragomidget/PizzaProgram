using Microsoft.AspNetCore.Mvc;
using PizzaV5.Data;
using PizzaV5.Models;

namespace PizzaV5.Controllers
{
    public class PizzaControllerFromDb : Controller
    {
        public IActionResult Index()
        {

            List<PizzaModelFromDb> pizzas = new List<PizzaModelFromDb>();

            PizzaDAO pizzaDao = new PizzaDAO();

            pizzas = pizzaDao.FetchAll();

            return View("Index",pizzas);

        }
    }
}

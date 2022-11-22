using la_mia_pizzeria_static.data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaList : Controller
    {
        public IActionResult Index()
        {
            PizzaDB pi = new PizzaDB();

            List<Pizza> pizzaList = pi.pizze.ToList();

            return View(pizzaList);
        }

        public IActionResult Show(int id)
        {
            PizzaDB pi = new PizzaDB();

            Pizza pizza = pi.pizze.Where(p => p.Id == id).FirstOrDefault();

            return View("show",pizza);
        }
    }
}

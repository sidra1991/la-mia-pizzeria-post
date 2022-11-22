﻿using la_mia_pizzeria_static.data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller


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

            return View("Show", pizza);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza pizza)
        {
            PizzaDB pi = new PizzaDB();

            pi.pizze.Add(pizza);
            pi.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
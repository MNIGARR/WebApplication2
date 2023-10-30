using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Menu;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {


        public string Index()
        {

            return "1. Drinks\n\n2. Fastfoods\n\n3. Hot Meals";
        }

        public IActionResult drinks()
        {

            List<Drink> drinks = new List<Drink>
            {
                    new Drink
                    {
                        Id=1,
                          Name="Coca-cola",
                          Price=0.8
                    },
                    new Drink
                    {
                        Id=2,
                          Name="Sarikiz",
                          Price=1
                    },
                    new Drink
                    {
                        Id=3,
                          Name="Sirab",
                          Price=0.50
                    },
                    new Drink
                    {
                        Id=4,
                          Name="Efes",
                          Price=2.90
                    }
            };
            var viewModel = new DrinkListViewModel
            {
                Drinks = drinks,
            };
            return View(viewModel);


        }
        public IActionResult hotmeals()
        {
            List<HotMeal> hotmeals = new List<HotMeal>
            {
                    new HotMeal
                    {
                        Id=1,
                          Name="pilov",
                          Price=0.80
                    },
                    new HotMeal
                    {
                        Id=2,
                          Name="dolma",
                          Price=1
                    },
                    new HotMeal
                    {
                        Id=3,
                          Name="xengel",
                          Price=0.50
                    },
                    
            };
            var viewModel = new HotMealsListViewModel
            {
                HotMeals = hotmeals,
            };
            return View(viewModel);
        }
        public IActionResult fastfoods()
        {
            List<Fastfood> fastfoods = new List<Fastfood>
            {
                    new Fastfood
                    {
                        Id=1,
                          Name="pizza",
                          Price=0.80
                    },
                    new Fastfood
                    {
                        Id=2,
                          Name="burger",
                          Price=1
                    },
                    new Fastfood
                    {
                        Id=3,
                          Name="fries",
                          Price=0.50
                    },

            };
            var viewModel = new FastfoodListViewModel
            {
                Fastfoods = fastfoods,
            };
            return View(viewModel);
        }


    }
}

using asp.net_task1.Entity;
using asp.net_task1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace asp.net_task1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public List<Drink> drinks = new List<Drink>
        {
            new Drink
            {
                Id = 1,
                Name = "Coca-Cola",
                Category = "Soft Drink",
                IsAlcoholic = false,
                Packaging = "Can",
                Volume = 0.355f, // 355 ml
                Calories = 140.0f,
                Price = 1.50f
            },
            new Drink
            {
                Id = 2,
                Name = "Orange Juice",
                Category = "Juice",
                IsAlcoholic = false,
                Packaging = "Bottle",
                Volume = 1.0f, // 1 liter
                Calories = 120.0f,
                Price = 3.00f
            },
            new Drink
            {
                Id = 3,
                Name = "Lager Beer",
                Category = "Alcoholic Beverage",
                IsAlcoholic = true,
                Packaging = "Bottle",
                Volume = 0.5f, // 500 ml
                Calories = 150.0f,
                Price = 2.50f
            }
        };

        public List<FastFood> fastFoods = new List<FastFood>
        {
            new FastFood
            {
                Id = 1,
                Name = "Cheeseburger",
                PreparationTime = 15,
                SpecialAdding = "Extra cheese",
                Category = "Fast Food",
                Calories = 300.0f,
                Price = 5.99f
            },
            new FastFood
            {
                Id = 2,
                Name = "Caesar Salad",
                PreparationTime = 10,
                SpecialAdding = "No croutons",
                Category = "Salad",
                Calories = 150.0f,
                Price = 7.50f
            },
            new FastFood
            {
                Id = 3,
                Name = "Margherita Pizza",
                PreparationTime = 20,
                SpecialAdding = "Extra basil",
                Category = "Pizza",
                Calories = 250.0f,
                Price = 12.00f
            }
        };

        public List<HotMeal> hotMeals = new List<HotMeal>
        {
            new HotMeal
            {
                Id = 1,
                Name = "Spaghetti Bolognese",
                ServingSize = 1,
                IsVegetarian = false,
                SpiceLevel = "Mild",
                Category = "Main Course",
                Calories = 450.0f,
                Price = 12.99f
            },
            new HotMeal
            {
                Id = 2,
                Name = "Vegetable Curry",
                ServingSize = 2,
                IsVegetarian = true,
                SpiceLevel = "Medium",
                Category = "Main Course",
                Calories = 300.0f,
                Price = 10.50f
            },
            new HotMeal
            {
                Id = 3,
                Name = "Chicken Wings",
                ServingSize = 3,
                IsVegetarian = false,
                SpiceLevel = "Hot",
                Category = "Appetizer",
                Calories = 600.0f,
                Price = 8.99f
            }
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                Drinks = drinks,
                FastFoods = fastFoods,
                HotMeals = hotMeals
            };
            return View(viewModel);
        }
        public IActionResult FastFoods()
        {
            var viewModel = new FastFoodsViewModel
            {
                FastFoods = fastFoods
            };
            return View(viewModel);
        }
        public IActionResult Drinks()
        {
            var viewModel = new DrinksViewModel
            {
                Drinks = drinks
            };
            return View(viewModel);
        }
        public IActionResult HotMeals()
        {
            var viewModel = new HotMealsViewModel
            {
                HotMeals = hotMeals
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

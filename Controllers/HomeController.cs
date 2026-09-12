using Lesson_4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson_4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var newProducts = new List<Product>()
            {
                new Product { Id = 1, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "\\Images\\Image1.webp", Price = 50000, SalePrice = 35000 },
                new Product { Id = 2, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "\\Images\\Image2.webp", Price = 50000, SalePrice = 35000 },
                new Product { Id = 3, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "\\Images\\Image3.webp", Price = 50000, SalePrice = 35000 }
            };

            return View(newProducts);
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

using Microsoft.AspNetCore.Mvc;
using Lesson_4.Models;
using System.Collections.Generic;

namespace Lesson_4.ViewComponents
{
    [ViewComponent(Name = "HotProduct")]
    public class HotProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // 3 sản phẩm mẫu cho phần dưới
            var hotProducts = new List<Product>()
            {
                new Product { Id = 4, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "\\Images\\Image1.webp", Price = 50000, SalePrice = 35000 },
                new Product { Id = 5, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "\\Images\\Image2.webp", Price = 50000, SalePrice = 35000 },
                new Product { Id = 6, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "\\Images\\Image3.webp", Price = 50000, SalePrice = 35000 }
            };

            return View(hotProducts);
        }
    }
}

using DersModelYapisi.Models;
using DersModelYapisi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisi.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var product1 = new Product { Id = 1, Name = "Apple", Price = 35 };
            var product2 = new Product { Id = 2, Name = "Pear", Price = 45 };
            var product3 = new Product { Id = 3, Name = "Orange", Price = 50 };

            var cartProduct1 = new CartProduct { Product = product1, Quantity = 5, Id = 1, Price = 35 };
            var cartProduct2 = new CartProduct { Product = product2, Quantity = 4, Id = 2, Price = 45 };
            var cartProduct3 = new CartProduct { Product = product3, Quantity = 3, Id = 3, Price = 50 };

            List<CartProduct> cartProducts = new List<CartProduct>();
            cartProducts.Add(cartProduct1);
            cartProducts.Add(cartProduct2);
            cartProducts.Add(cartProduct3);

            CartProductViewModel datas = new CartProductViewModel{ Products = cartProducts };

            decimal ToplamTutar = 0;
            decimal ToplamKDV = 0;
            foreach (var cartProduct in datas.Products)
            {
                ToplamTutar += (cartProduct.Price * Convert.ToDecimal(cartProduct.Quantity) * 1.20M);
                ToplamKDV += (cartProduct.Price * Convert.ToDecimal(cartProduct.Quantity) * 0.20M);
            }

            ViewBag.ToplamTutar = ToplamTutar;
            ViewBag.ToplamKDV = ToplamKDV;

            return View(datas);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Abstract;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository repository;

        public CartController(IProductRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index(Cart cart, string returnUrl)
        {
            return View(new CartViewModel { Cart = cart, ReturnUrl = returnUrl });
        }

        public RedirectToRouteResult AddToCart(Cart cart, int productId, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int productId, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                cart.RemoveItem(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }

        public ActionResult Checkout()
        {
            return View(new ShippingAddress());
        }

        [HttpPost]
        public ActionResult Checkout(Cart cart, ShippingAddress shippingAddress)
        {
            if (!cart.CartProducts.Any())
            {
                ModelState.AddModelError("","Your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                cart.Clear();
                return View("Completed");
            }
            return View(shippingAddress);
        }
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Abstract;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repository;

        public HomeController(IProductRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            return View(repository.Products);
        }
    }
}
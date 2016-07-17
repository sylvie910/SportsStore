using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Abstract;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public HomeController(IProductRepository repository)
        {
            this.repository = repository;
        }

        public ViewResult Index(int page = 1)
        {
            ProductListViewModel model = new ProductListViewModel
            {
                Products = repository.Products.OrderBy(p => p.ProductId).Skip((page - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            };
            return View(model);
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcSportStore.Data;
using MvcSportStore.Models;
using MvcSportStore.ViewModels;

namespace MvcSportStore.Controllers
{
    public class HomeController : Controller
    {
        StoreDbContext _context;
        private ProductRepository _repo;
        public HomeController(StoreDbContext context)
        {
            _context = context;
            _repo = new ProductRepository(_context.Products);
        }
        public IActionResult Index(int id = 1)
        {
            var productModel = _repo.GetProductModel(id);
            return View(productModel);
            //int filter = PagingSettings.ProductPagination;
            //return View(_context.Products.Take(filter));
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

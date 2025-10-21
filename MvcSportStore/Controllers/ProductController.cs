using Microsoft.AspNetCore.Mvc;
using MvcSportStore.Data;
using MvcSportStore.Models;

namespace MvcSportStore.Controllers
{
    public class ProductController : Controller
    {
        private StoreDbContext _context;
        public IActionResult Create()
        {
            Product prod = new Product();
            return View(prod);
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Products.Add(product);
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Home");

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Invalid Data! " + ex.Message.Substring(50));
                }
            }
            return View();
        }
    }
}

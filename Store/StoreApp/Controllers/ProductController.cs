using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly RepositoryContext _context;

        public ProductController(RepositoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> IndexEski()
        {
            return _context.Products;

            // var context = new RepositoryContext(
            //     new DbContextOptionsBuilder<RepositoryContext>()
            //     .UseSqlite("Data Source = D:\\GitHub\\BTKAkademi_ASPNET-Core-MVC\\ProductDb.db")
            //     .Options
            // );
            // return context.Products;

            // return new List<Product>()
            // {
            //     new Product(){ProductId=1, ProductName="Computer", Price=5}
            // };
        }

        public IActionResult Index()
        {
            var model = _context.Products.ToList();
            return View(model);
        }

        public IActionResult Get(int ID)
        {
            Product product = _context.Products.First(p => p.ProductId.Equals(ID));
            return View(product);
        }
    }
}
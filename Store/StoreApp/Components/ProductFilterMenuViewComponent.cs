using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Componenets
{
    public class ProductFilterMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
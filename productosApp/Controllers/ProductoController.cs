using Microsoft.AspNetCore.Mvc;
using productosApp.Models;
namespace productosApp.Controllers
{
    public class ProductoController : Controller
    {
        public BodegaContext context;

        public ProductoController(BodegaContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

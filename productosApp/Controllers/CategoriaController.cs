using Microsoft.AspNetCore.Mvc;
using productosApp.Models;

namespace productosApp.Controllers
{
    public class CategoriaController : Controller
    {
        public BodegaContext context;
        CategoriaController(BodegaContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista()
        {

            return View();
        }
    }
}

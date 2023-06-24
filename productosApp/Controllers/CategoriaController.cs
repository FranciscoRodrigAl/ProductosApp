using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using productosApp.Models;

namespace productosApp.Controllers
{
    public class CategoriaController : Controller
    {
        public BodegaContext context;
        public CategoriaController(BodegaContext context)
        {
            this.context = context;
        }

        public IActionResult Nueva()
        {
            Categoria newCategoria = new Categoria();
            return View(newCategoria);
        }

        public IActionResult Guardar(Categoria categoria)
        {
            if(ModelState.IsValid)
            {
                this.context.Categories.Add(categoria);
                this.context.SaveChanges();
                return RedirectToAction("Lista");
            }
            else
            {
                return View("Nueva",categoria);
            }
        }

        public IActionResult Lista()
        {
            List<Categoria> lista = this.context.Categories.Include(c => c.Productos).ToList();
            return View(lista);
        }
    }
}

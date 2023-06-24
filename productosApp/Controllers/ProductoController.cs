using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            List<Producto> products = context.Products.Include(p => p.Categoria).ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            List<Categoria> categories = this.context.Categories.ToList();
            ViewBag.Categories = categories;
            Producto p = new Producto();
            return View(p);
        }

        public IActionResult Save(Producto p)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    this.context.Products.Add(p);
                    this.context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            else
            {
                List<Categoria> categories = this.context.Categories.ToList();
                ViewBag.Categories = categories;

                return View("Create", p);//RedirectToAction("Create",p);
            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc3b.Models;
using Microsoft.EntityFrameworkCore;

namespace pc3b.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductoContext _context;

        public HomeController(ILogger<HomeController> logger,ProductoContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var Rproducto = _context.Productos.ToList();
                                        

            return View(Rproducto);
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar (Producto objProducto)
        {
            if (ModelState.IsValid) {
                // Guardar el objeto "sa" en la BD
                
                _context.Add(objProducto);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(objProducto);
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

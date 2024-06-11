using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyecto.Core.Business;
using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Configurations;
using Proyecto.Core.Data;
using Proyecto.Core.Entities;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    public class CompraController : Controller
    {
        private readonly ILogger<CompraController> _logger;

        //Se inyecta las dependencias para usar el business de ejemplo
        private readonly ICompraBusiness _compraBusiness;
        private readonly IProductoBusiness _productoBusiness;
        private readonly ICategoriaBusiness _categoriaBusiness;
        

        public CompraController(ICompraBusiness compraBusiness, IProductoBusiness productoBusiness, 
                                    ICategoriaBusiness categoriaBusiness,
                                    ILogger<CompraController> logger)
        {
            _logger = logger;
            _compraBusiness = compraBusiness;
            _productoBusiness = productoBusiness;
            _categoriaBusiness = categoriaBusiness;
        }

        // GET: CompraController 

        public ActionResult Index()
        {

            var ViewModel = new CompraVM()
            {
                CompraLista = _compraBusiness.GetCompras()
            };

            return View(ViewModel);

        }

        [HttpGet]
        public IActionResult Details()
        {

            var compras = _compraBusiness.GetCompras();

            compras = (from c in compras
                       where c.Producto.CategoriaId == 1 && c.ProductoId == 10
                       //where c.ProductoId == 10
                       select c).ToList();

            var ViewModel = new CompraVM
            {
                CompraLista = compras
            };

            return View(ViewModel);

        }


        [HttpPost]
        public IActionResult Details(CompraVM compraVM)
        {

            if (compraVM._Compra.CompraId != 0)
            {
                _compraBusiness.AddCompra(compraVM._Compra);
            }

            return View();

        }


        //Get  compra/create
        public IActionResult Create()
        {

            var ViewModel = new CompraVM()
            {
                _Compra = new Compra(),
                ProductoLista = new List<Producto>()
            };


            return View(ViewModel);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(CompraVM compraVM)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        compraVM._Producto = _productoBusiness.GetProducto(10);
        //        return View(compraVM);
        //    }

        //    var fechaActual = DateTime.Now;
        //    if (compraVM._Compra.Fecha > fechaActual || compraVM._Compra.Fecha < fechaActual.AddDays(-7))
        //    {
        //        ModelState.AddModelError("FechaCompra", "La fecha de la compra no puede ser mayor a 7 días atrás ni una fecha futura.");
        //        compraVM._Producto = _productoBusiness.GetProducto(10);
        //        return View(compraVM);
        //    }

        //    _compraBusiness.AddCompra(compraVM._Compra);
        //    return RedirectToAction(nameof(Index));
        //}
    }

   
}

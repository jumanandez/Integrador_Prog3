using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Proyecto.Core.Business;
using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Configurations;
using Proyecto.Core.Data;
using Proyecto.Core.Entities;
using System.Security.Claims;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    [Authorize]
    public class CompraController : Controller
    {
        private readonly ILogger<CompraController> _logger;

        //Se inyecta las dependencias para usar el business de ejemplo
        private readonly ICompraBusiness _compraBusiness;
        private readonly ICategoriaBusiness _categoriaBusiness;
        private readonly IProductoBusiness _productoBusiness;



        public CompraController(ICompraBusiness compraBusiness,
                                ICategoriaBusiness categoriaBusiness,
                                IProductoBusiness productoBusiness,
                                ILogger<CompraController> logger)
        {
            _logger = logger;
            _compraBusiness = compraBusiness;
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
                return RedirectToAction("Index");
            }

            return View(compraVM);

        }

            var CompraNueva = new Models.ViewModels.CompraVM()
            {

                CompraLista = _compraBusiness.GetCompras()
            };


            return View(CompraNueva);
        }

        //post compra/create
        //[HttpPost]
        //public async Task<IActionResult> Create(CompraVM compraModel)
        //{
        //if (ModelState.IsValid)
        //{
        //    var compra = new Compra
        //    {
        //        ProductoId = compraModel._Compra.ProductoId,
        //        Fecha = compraModel._Compra.Fecha,
        //        Cantidad = compraModel._Compra.Cantidad,
        //        UsuarioId = 1 // Ajusta esto según el usuario actual
        //    };

        //    _compraBusiness.AddCompra(compra);
        //    await _compraBusiness.SaveChangesAsync();

        //post compra/create
        [HttpPost]
        public IActionResult Create(CompraVM compraModel)
        {
            if (ModelState.IsValid)
            {
                var fechaActual = DateTime.Now;
                var fechaLimitePasada = fechaActual.AddDays(-7);
                var fechaLimiteFutura = fechaActual;

                if (compraModel.FechaCompra < fechaLimitePasada || compraModel.FechaCompra > fechaLimiteFutura)
                {
                    ModelState.AddModelError("FechaCompra", "La fecha de compra debe estar dentro de los últimos 7 días y no puede ser una fecha futura.");
                }

                if (ModelState.IsValid)
                {
                    var compra = new Compra
                    {
                        ProductoId = compraModel.ProductoId,
                        Fecha = compraModel.FechaCompra,
                        Cantidad = compraModel.ProductoCantidad,
                        UsuarioId = int.Parse(User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).Select(c => c.Value).SingleOrDefault())
                    };

                    _compraBusiness.AddCompra(compra);

                    return RedirectToAction("Create", "Compra");
                }
            }

            // Vuelve a cargar la lista de categorías y productos en caso de error de validación
            compraModel.CategoriaLista = _categoriaBusiness.GetAll();
            compraModel.ProductoLista = _productoBusiness.GetAll();
            return View(compraModel);
        }






    }
}

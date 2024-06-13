using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            _categoriaBusiness = categoriaBusiness;
            _productoBusiness = productoBusiness;
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

        public IActionResult Details(int? CategoriaId, int id)
        {
            var compras = _compraBusiness.GetCompras();

            compras = (from c in compras
                       where c.Producto.CategoriaId == CategoriaId.Value
                       where c.ProductoId == id
                       select c).ToList();

            var ViewModel = new CompraVM
            {
                CompraLista = compras
            };

            return View(ViewModel);

        }


        //Get  compra/create
        public IActionResult Create()
        {

            var CompraNueva = new Models.ViewModels.CompraVM()
            {

                CompraLista = _compraBusiness.GetCompras()
            };

            return View(CompraNueva);

        }

        [HttpGet]
        public JsonResult GetProductosByCategoria(int categoriaId)
        {
            var productos = _productoBusiness.GetProductosByCategoria(categoriaId);
            return Json(productos);
        }

        //post compra/create
        [HttpPost]
        public IActionResult Create(CompraVM compraModel)
        {
            if (!ModelState.IsValid)
            {
                // Log errors
                var errors = ModelState.Values.SelectMany(v => v.Errors).ToList();
                foreach (var error in errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }

                // Vuelve a cargar la lista de categorías y productos en caso de error de validación
                compraModel.CategoriaLista = _categoriaBusiness.GetAll();
                compraModel.ProductoLista = _productoBusiness.GetAll();
                return View(compraModel);
            }

            var compra = new Compra
            {
                ProductoId = compraModel.ProductoId,
                Fecha = DateTime.Now,
                Cantidad = compraModel.ProductoCantidad,
                UsuarioId = int.Parse(User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).Select(c => c.Value).SingleOrDefault())
            };

            _compraBusiness.AddCompra(compra);

            return RedirectToAction("Create", "Compra");
        }
    }
}

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
            _categoriaBusiness = categoriaBusiness;
            _productoBusiness = productoBusiness;
        }

        // GET: CompraController 


        public ActionResult Index()
        {
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var ViewModel = new CompraVM()
            {
                CompraLista = _compraBusiness.GetCompras(userId)
            };

            return View(ViewModel);
        }

        public IActionResult Create()
        {
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var CompraNueva = new CompraVM()
            {
                CategoriaLista = _categoriaBusiness.GetAll(),
                CompraLista = _compraBusiness.GetCompras(userId)
            };

            return View(CompraNueva);

        }

        [HttpGet]
        public JsonResult GetProductosByCategoria(int categoriaId)
        {
            var productos = _productoBusiness.GetProductosByCategoria(categoriaId);

            return Json(productos);
        }

        [HttpPost]
        public IActionResult Create(CompraVM compraModel)
        {
            if (ModelState.IsValid)
            {
                
                if (_compraBusiness.VerificarFecha(compraModel.FechaCompra))
                {
                    ModelState.AddModelError("FechaCompra", "La fecha de compra debe estar dentro de los últimos 7 días y no puede ser una fecha futura.");
                }

                if (ModelState.IsValid)
                {
                    int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                    var compra = new Compra
                    {
                        ProductoId = compraModel.ProductoId,
                        Fecha = compraModel.FechaCompra,
                        Cantidad = compraModel.ProductoCantidad,
                        UsuarioId = userId
                    };

                    _compraBusiness.AddCompra(compra);

                    return RedirectToAction("Index", "Compra");
                }
            }

            // Vuelve a cargar la lista de categorías y productos en caso de error de validación
            compraModel.CategoriaLista = _categoriaBusiness.GetAll();
            compraModel.ProductoLista = _productoBusiness.GetAll();
            return View(compraModel);
        }






    }
}

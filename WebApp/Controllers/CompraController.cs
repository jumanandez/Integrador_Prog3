using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Core.Business.Interfaces;
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


        public ActionResult Index(int pagina = 1, int itemsPorPagina = 8)
        {
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            var viewModel = new CompraVM
            {
                Paginado = _compraBusiness.GetComprasPaginadas(pagina, itemsPorPagina, userId)
            };

            return View(viewModel);
        }
        public IActionResult Create()
        {
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var oCompraVM = new CompraVM()
            {
                CategoriaLista = _categoriaBusiness.GetAll(),
                CompraLista = _compraBusiness.GetCompras(userId)
            };

            return View(oCompraVM);

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
                
                if (_compraBusiness.VerificarFecha((DateTime)compraModel.FechaCompra))
                {
                    ModelState.AddModelError("FechaCompra", "La fecha de compra debe estar dentro de los últimos 7 días y no puede ser una fecha futura.");
                }

                if (ModelState.IsValid)
                {
                    int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                    var compra = new Compra
                    {
                        ProductoId = (int)compraModel.ProductoId,
                        Fecha = (DateTime)compraModel.FechaCompra,
                        Cantidad = (int)compraModel.ProductoCantidad,
                        UsuarioId = userId
                    };

            _compraBusiness.AddCompra(compra);

            return RedirectToAction("Create", "Compra");
        }

    }
}

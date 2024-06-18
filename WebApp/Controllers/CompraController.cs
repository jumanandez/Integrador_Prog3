using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Entities;
using System;
using System.Linq;
using System.Security.Claims;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    [Authorize]
    public class CompraController : Controller
    {
        private readonly ILogger<CompraController> _logger;
        private readonly ICompraBusiness _compraBusiness;
        private readonly ICategoriaBusiness _categoriaBusiness;
        private readonly IProductoBusiness _productoBusiness;

        public CompraController(
            ICompraBusiness compraBusiness,
            ICategoriaBusiness categoriaBusiness,
            IProductoBusiness productoBusiness,
            ILogger<CompraController> logger)
        {
            _logger = logger;
            _compraBusiness = compraBusiness;
            _categoriaBusiness = categoriaBusiness;
            _productoBusiness = productoBusiness;
        }

        public IActionResult Index(int pagina = 1, int itemsPorPagina = 8)
        {
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            var viewModel = new CompraVM
            {
                Paginado = _compraBusiness.GetComprasPaginadas(pagina, itemsPorPagina, userId, null)
            };

            return View(viewModel);
        }

        public IActionResult Create()
        {
            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var viewModel = new CompraVM
            {
                CompraId = 0,
                CategoriaLista = _categoriaBusiness.GetAll(),
                CompraLista = _compraBusiness.GetCompras(userId)
            };

            return View(viewModel);
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
            
            if (_compraBusiness.VerificarFecha(compraModel.FechaCompra.GetValueOrDefault()))
            {
                ModelState.AddModelError("FechaCompra", "La fecha de compra debe estar dentro de los últimos 7 días y no puede ser una fecha futura.");
            }

            if(compraModel.ProductoCantidad == null)
            {
                ModelState.AddModelError("ProductoCantidad", "Debe comprar al menos 1 item.");
            }

            if (compraModel.ProductoId == null)
            {
                ModelState.AddModelError("ProductoId", "Debe seleccionar un producto para realizar la compra.");
            }

            if (ModelState.IsValid)
            {
                var compra = new Compra
                {
                    ProductoId = (int)compraModel.ProductoId,
                    Fecha = compraModel.FechaCompra.GetValueOrDefault(),
                    Cantidad = (int)compraModel.ProductoCantidad,
                    UsuarioId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value)      
                };

                _compraBusiness.AddCompra(compra);

                return RedirectToAction("Index");

            }
            
            compraModel.CategoriaLista = _categoriaBusiness.GetAll();
            compraModel.CompraLista = _compraBusiness.GetCompras(int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value));
            return View(compraModel);
        }

        public IActionResult Edit(int compraId)
        {
            var compra = _compraBusiness.GetCompraById(compraId);
            if (compra == null)
            {
                return NotFound();
            }

            var viewModel = new CompraVM
            {
                CompraId = compra.CompraId,
                ProductoId = compra.ProductoId,
                ProductoCantidad = compra.Cantidad,
                FechaCompra = compra.Fecha,
                CategoriaId = compra.Producto?.CategoriaId, 
                                                                 
            };

            return View("Create", viewModel);
        }


        [HttpPost]
        public IActionResult Edit(CompraVM compraModel)
        {
            if (!ModelState.IsValid)
            {
                // Si el modelo no es válido, devolvemos la vista con los errores
                return View("Create",compraModel);
            }

            // Verificar si la fecha de compra está dentro del rango permitido
            if (_compraBusiness.VerificarFecha(compraModel.FechaCompra.GetValueOrDefault()))
            {
                ModelState.AddModelError("FechaCompra", "La fecha de compra debe estar dentro de los últimos 7 días y no puede ser una fecha futura.");
                return View("Create", compraModel);
            }

            // Obtener la compra original desde la capa de negocios
            var compra = _compraBusiness.GetCompraById((int)compraModel.CompraId);
            if (compra == null)
            {
                return NotFound();
            }

            compra.ProductoId = compraModel.ProductoId ?? compra.ProductoId;  // Manejar el caso de ProductoId nullable
            compra.Cantidad = compraModel.ProductoCantidad ?? compra.Cantidad; // Manejar el caso de ProductoCantidad nullable
            compra.Fecha = compraModel.FechaCompra.Value;

            _compraBusiness.UpdateCompra(compra);

            return RedirectToAction("Index", "Compra");
        }


        [HttpPost]
        public IActionResult Delete(int compraId)
        {
            _compraBusiness.DeleteCompra(compraId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Filter(int selectOption, string search, int pagina = 1, int itemsPorPagina = 8)
        {
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            var comprasFiltradas = _compraBusiness.OptionSelectFilter(search, selectOption);

            var oCompraVM = new CompraVM()
            {
                Paginado = _compraBusiness.GetComprasPaginadas(pagina, itemsPorPagina, userId, comprasFiltradas)
            };

            return View("Index", oCompraVM);
        }
    }
}


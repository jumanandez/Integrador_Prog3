using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
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
        private readonly IVentaBusiness _ventaBusiness;
		private readonly ICategoriaBusiness _categoriaBusiness;
		private readonly IProductoBusiness _productoBusiness;
		private readonly CompraService _compraService;
		private List<Compra> _currentFiltered = null!;

		public CompraController(
			ICompraBusiness compraBusiness,
			ICategoriaBusiness categoriaBusiness,
			IProductoBusiness productoBusiness,
            IVentaBusiness ventaBusiness,
			ILogger<CompraController> logger,
			CompraService compraService)
		{
			_logger = logger;
			_compraBusiness = compraBusiness;
            _ventaBusiness = ventaBusiness;
			_categoriaBusiness = categoriaBusiness;
			_productoBusiness = productoBusiness;
			_compraService = compraService;
		}
		public IActionResult Index(string search, int selectOption, bool refresh, string sortOrder, string searchString, string currentFilter, int? pagina, int itemsPorPagina = 8)
		{
			int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

			var viewModel = new CompraVM
			{
				Paginado = _compraBusiness.GetComprasPaginadas(pagina ?? 1, itemsPorPagina, userId, SortOrSearch(search, selectOption, userId, refresh, sortOrder, searchString, currentFilter, pagina, itemsPorPagina))
			};

            return View(viewModel);
        }
        public List<Compra> SortOrSearch(string search, int selectOption, int userId, bool refresh, string sortOrder, string searchString, string currentFilter, int? pagina, int itemsPorPagina = 8)
        {
            if (_compraService.CurrentFiltered == null || _compraService.CurrentFiltered.Count == 0)
            {
                _currentFiltered = _compraBusiness.GetCompras(userId);
                _compraService.CurrentFiltered = _currentFiltered;
            }
            else
            {
                _currentFiltered = _compraService.CurrentFiltered;
            }
            ViewData["CurrentSort"] = sortOrder;
            ViewData["DateSortParm"] = String.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
            ViewData["NameSortParm"] = sortOrder == "Name" ? "name_desc" : "Name";
            ViewData["AmmountSortParm"] = sortOrder == "Ammount" ? "ammount_desc" : "Ammount";
            ViewData["StockSortParm"] = sortOrder == "Stock" ? "stock_desc" : "Stock";
            
            if (searchString != null)
            {
                pagina = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentOption"] = selectOption;
            if (refresh)
            {
                _currentFiltered = _compraBusiness.GetCompras(userId);
                _compraService.CurrentFiltered = _currentFiltered;
                return _currentFiltered;
            }
            else
            {
                if (!String.IsNullOrEmpty(searchString))
                {
                    _currentFiltered = _currentFiltered.Where(s => s.Producto.Nombre.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
                }
                if (selectOption > 0)
                {
                    sortOrder = selectOption == 2 ? "date" : "ammount";
                    _currentFiltered = Filter(userId, selectOption, search, _currentFiltered);
                }

                switch (sortOrder)
                {
                    case "date_desc":
                        _currentFiltered = _currentFiltered.OrderBy(s => s.Fecha).ToList();
                        break;
                    case "Name":
                        _currentFiltered = _currentFiltered.OrderBy(s => s.Producto.Nombre).ToList();
                        break;
                    case "name_desc":
                        _currentFiltered = _currentFiltered.OrderByDescending(s => s.Producto.Nombre).ToList();
                        break;
                    case "Ammount":
                        _currentFiltered = _currentFiltered.OrderByDescending(s => s.Cantidad).ToList();
                        break;
                    case "ammount_desc":
                        _currentFiltered = _currentFiltered.OrderBy(s => s.Cantidad).ToList();
                        break;
                    case "Stock":
                        _currentFiltered = _currentFiltered.OrderByDescending(p => p.Producto.Compras.Select(c => c.Cantidad).Sum() - p.Producto.Venta.Select(v => v.Cantidad).Sum()).ToList();
                        break;
                    case "stock_desc":
                        _currentFiltered = _currentFiltered.OrderBy(p => p.Producto.Compras.Select(c => c.Cantidad).Sum() - p.Producto.Venta.Select(v => v.Cantidad).Sum()).ToList();
                        break;
                    default:
                        _currentFiltered = _currentFiltered.OrderByDescending(s => s.Fecha).ToList();
                        break;
                }
                _compraService.CurrentFiltered = _currentFiltered;
                return _currentFiltered;
            }
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
            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            if (compraModel.CategoriaId == null)
            {
                ModelState.AddModelError("CategoriaId", "Debe seleccionar una categoria.");
            }
            if (_compraBusiness.VerificarFecha(compraModel.FechaCompra.GetValueOrDefault()))
            {
                ModelState.AddModelError("FechaCompra", "La fecha de compra debe estar dentro de los últimos 7 días y no puede ser una fecha futura.");
            }

            if (compraModel.ProductoCantidad == null || compraModel.ProductoCantidad < 1)
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

				return RedirectToAction("Index", new { refresh = true });

            }

            compraModel.CategoriaLista = _categoriaBusiness.GetAll();
            compraModel.CompraLista = _compraBusiness.GetCompras(userId);
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
                Llamado = 1,

			};

			return View("Create", viewModel);
		}


        [HttpPost]
        public IActionResult Edit(CompraVM compraModel)
        {
            var compra = _compraBusiness.GetCompraById((int)compraModel.CompraId);
            if (compra == null)
            {
                compraModel.Llamado = 1;
                return NotFound();
            }
            var UsuarioId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            if (compraModel.ProductoCantidad == null || compraModel.ProductoCantidad < 1)
            {
                compraModel.Llamado = 1;
                ModelState.AddModelError("ProductoCantidad", "Debe comprar al menos 1 item.");
            }
            if (IsTooLow(UsuarioId, (int)compraModel.ProductoCantidad, compra.ProductoId))
            {
                compraModel.Llamado = 1;
                ModelState.AddModelError("ProductoCantidad", "Las compras no pueden ser menores a las ventas!");
            }
            if (!ModelState.IsValid)
            {
                // Si el modelo no es válido, devolvemos la vista con los errores
                compraModel.Llamado = 1;
                return View("Create", compraModel);
            }
            // Verificar si la fecha de compra está dentro del rango permitido
            if (_compraBusiness.VerificarFecha(compraModel.FechaCompra.GetValueOrDefault()))
			{
                compraModel.Llamado = 1;
                ModelState.AddModelError("FechaCompra", "La fecha de compra debe estar dentro de los últimos 7 días y no puede ser una fecha futura.");
				return View("Create", compraModel);
			}

			// Obtener la compra original desde la capa de negocios

			compra.ProductoId = compraModel.ProductoId ?? compra.ProductoId;  // Manejar el caso de ProductoId nullable
			compra.Cantidad = compraModel.ProductoCantidad ?? compra.Cantidad; // Manejar el caso de ProductoCantidad nullable
			compra.Fecha = compraModel.FechaCompra.Value;

			_compraBusiness.UpdateCompra(compra);

			return RedirectToAction("Index", "Compra", new { refresh = true });
		}

        public IActionResult RepetirCompra(int compraId)
        {
            var compra = _compraBusiness.GetCompraById(compraId);


			if (compra == null)
            {
                return NotFound();
            }

            var viewModel = new CompraVM
            {
                CompraId = 0,
                ProductoId = compra.ProductoId,
                ProductoCantidad = compra.Cantidad,
                FechaCompra = DateTime.Now,
                CategoriaId = compra.Producto?.CategoriaId,
                Llamado = 2
            };

            return View("Create", viewModel);
        }

        [HttpPost]
        public IActionResult RepetirCompra(CompraVM compraModel)
        {
            if (compraModel.ProductoCantidad == null || compraModel.ProductoCantidad < 1)
            {
                compraModel.Llamado = 2;
                ModelState.AddModelError("ProductoCantidad", "Debe comprar al menos 1 item.");
            }
            if (!ModelState.IsValid)
            {
                // Si el modelo no es válido, devolvemos la vista con los errores
                compraModel.Llamado = 2;
                return View("Create", compraModel);
            }

            if (_compraBusiness.VerificarFecha(compraModel.FechaCompra.GetValueOrDefault()))
            {
                compraModel.Llamado = 2;
                ModelState.AddModelError("FechaCompra", "La fecha de compra debe estar dentro de los últimos 7 días y no puede ser una fecha futura.");
                return View("Create", compraModel);
            }

            //Obtener la compra original desde la capa de negocios
           var compra = _compraBusiness.GetCompraById((int)compraModel.CompraId);

            if (compra == null)
            {
                return NotFound();
            }

            compra.ProductoId = compraModel.ProductoId ?? compra.ProductoId;  // Manejar el caso de ProductoId nullable

            if (ModelState.IsValid)
            {
                var comprad = new Compra
                {
                    ProductoId = compraModel.ProductoId ?? compra.ProductoId,
                    Fecha = compraModel.FechaCompra.GetValueOrDefault(),
                    Cantidad = (int)compraModel.ProductoCantidad,
                    UsuarioId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)
                };

                _compraBusiness.AddCompra(comprad);
            }
            return RedirectToAction("Index", "Compra", new { refresh = true });
        }


        [HttpPost]
		public IActionResult Delete(int compraId)
		{
            //_compraBusiness.DeleteCompra(compraId);
            return RedirectToAction("Index");
        }

		//[HttpGet]
		//public IActionResult Filter(int selectOption, string search, int? pagina, int itemsPorPagina = 8)
		//{
		//    int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
		//    if (_compraService.CurrentFiltered == null || _compraService.CurrentFiltered.Count == 0)
		//    {
		//        _currentFiltered = _compraBusiness.GetCompras(userId);
		//        _compraService.CurrentFiltered = _currentFiltered;
		//    }
		//    else
		//    {
		//        _currentFiltered = _compraService.CurrentFiltered;
		//    }

		//    //var comprasFiltradas = _compraBusiness.OptionSelectFilter(search, selectOption, userId, _currentFiltered); ;

		//    var oCompraVM = new CompraVM()
		//        {
		//            Paginado = _compraBusiness.GetComprasPaginadas(pagina ?? 1, itemsPorPagina, userId, Filter(userId, selectOption, search, pagina, _currentFiltered, itemsPorPagina))
		//        };
		//        return View("Index", oCompraVM);
		//}
		public List<Compra> Filter(int userId, int selectOption, string search, List<Compra> comprasSinfiltro)
		{
			var comprasFiltradas = _compraBusiness.OptionSelectFilter(search, selectOption, userId, comprasSinfiltro);

			return comprasFiltradas.ToList();
		}
        public bool IsTooLow(int UserId, int Cantidad, int productoId)
        {
            return ((_productoBusiness.GetStock(UserId, productoId) - Cantidad) - _ventaBusiness.GetVentaProducto(UserId, productoId) < 0);
        }
	}
}


﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Proyecto.Core.Business;
using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Configurations;
using Proyecto.Core.Data;
using Proyecto.Core.Entities;
using System.Security.Claims;
using WebApp.Models;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    [Authorize]
    public class VentaController : Controller
    {
        private readonly ILogger<VentaController> _logger;
        private readonly IVentaBusiness _ventaBusiness;
        private readonly ICompraBusiness _compraBusiness;
        private readonly IProductoBusiness _productoBusiness;
        private readonly ICategoriaBusiness _categoriaBusiness;
        private readonly IUsuarioBusiness _usuarioBusiness;
        private readonly CompraService _compraService;
        private List<Venta> _currentFiltered = null!;



        public VentaController(IVentaBusiness ventaBusiness,
                               ICompraBusiness compraBusiness,
                               IProductoBusiness productoBusiness,
                               ICategoriaBusiness categoriaBusiness,
                               IUsuarioBusiness usuarioBusiness,
                               ILogger<VentaController> logger,
                               CompraService compraService)
        {
            _logger = logger;
            _ventaBusiness = ventaBusiness;
            _compraBusiness = compraBusiness;
            _productoBusiness = productoBusiness;
            _categoriaBusiness = categoriaBusiness;
            _usuarioBusiness = usuarioBusiness;
            _compraService = compraService;

        }


        // GET: VentaController
        public IActionResult Index(string search, int selectOption, bool refresh, string sortOrder, string searchString, string currentFilter, int? pagina, int itemsPorPagina = 5)
        {

            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            var ViewModel = new VentaVM()
            {
                CompraLista = _compraBusiness.GetCompras(userId),
                Paginado = _ventaBusiness.GetVentasPaginadas(pagina ?? 1, itemsPorPagina, userId, SortOrSearch(search, selectOption, userId, refresh, sortOrder, searchString, currentFilter, pagina, itemsPorPagina))
            };

            return View(ViewModel);
        }

        public List<Venta> SortOrSearch(string search, int selectOption, int userId, bool refresh, string sortOrder, string searchString, string currentFilter, int? pagina, int itemsPorPagina = 5)
        {
            if (_compraService.CurrentVentaFiltered == null || _compraService.CurrentVentaFiltered.Count == 0)
            {
                _currentFiltered = _ventaBusiness.GetVentas(userId);
                _compraService.CurrentVentaFiltered = _currentFiltered;
            }
            else
            {
                _currentFiltered = _compraService.CurrentVentaFiltered;
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
                _currentFiltered = _ventaBusiness.GetVentas(userId);
                _compraService.CurrentVentaFiltered = _currentFiltered;
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
                    _currentFiltered = Filter(userId, search, _currentFiltered);
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
                _compraService.CurrentVentaFiltered = _currentFiltered;
                return _currentFiltered;
            }
        }
        public IActionResult Create()
        {
            var ventaModel = new VentaVM
            {
                VentaId = 0,
                CategoriaLista = _categoriaBusiness.GetAll().OrderBy(c => c.Nombre).ToList(),
                ProductoLista = new List<Producto>()
            };
            ModelState.AddModelError("CategoriaId", "(*)Campo obligatorio.");
            return View(ventaModel);
        }
        [HttpPost]
        public IActionResult Create(VentaVM ventaModel)
        {
            var userID = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            if( ventaModel.ProductoId == null)
            {
                ModelState.AddModelError("ProductoId", "Seleccione un producto!.");
                ventaModel.CategoriaLista = _categoriaBusiness.GetAll().OrderBy(c => c.Nombre).ToList();
                return View(ventaModel);
            }

            if (ventaModel.CategoriaSeleccionada != 0)
            {
                ventaModel.ProductoLista = _productoBusiness.GetAllWeb()
                    .Where(p => p.CategoriaId == ventaModel.CategoriaSeleccionada)
                    .OrderBy(p => p.Nombre)
                    .ToList();
            }
            if (ventaModel.ProductoId != null || ventaModel.Cantidad != null)
            {

                if (_productoBusiness.GetStock(userID, (int)ventaModel.ProductoId) < ventaModel.Cantidad)
                {
                    ModelState.AddModelError("Cantidad", "La cantidad de venta no puede superar el total disponible en stock.");
                }

                if (ModelState.IsValid && ventaModel.Cantidad == null)
                {
                    ModelState.AddModelError("Cantidad", "Debe ingresar la cantidad de productos");
                }
                else if (ModelState.IsValid && ventaModel.Cantidad > 0)
                {
                    var nuevaVenta = new Venta
                    {
                        Fecha = DateTime.Now,
                        ProductoId = (int)ventaModel.ProductoId,
                        Cantidad = (int)ventaModel.Cantidad,
                        UsuarioId = userID
                    };

                    _ventaBusiness.AddVenta(nuevaVenta);
                    return RedirectToAction("Index", new { refresh = true });
                }

                ventaModel.CategoriaLista = _categoriaBusiness.GetAll().OrderBy(c => c.Nombre).ToList();
                return View(ventaModel);
            }
            else {
                ventaModel.CategoriaLista = _categoriaBusiness.GetAll().OrderBy(c => c.Nombre).ToList();
                return View(ventaModel);
            }
        }
        public IActionResult Edit(int ventaId)
        {
            var userID = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var venta = _ventaBusiness.GetVentaById(ventaId);

            if (venta != null)
            {

                if (userID != venta.UsuarioId)
                {
                    var errorModel = new ErrorViewModel
                    {
                        RequestId = "Usuario no autorizado!"
                    };
                    return View("Error", errorModel);
                }
                else
                {
                    if (venta == null)
                    {
                        return NotFound();
                    }

                    var stockProducto = _productoBusiness.GetStock(userID, venta.ProductoId);

                    var ventaModel = new VentaVM
                    {
                        VentaId = venta.VentaId,
                        ProductoId = venta.ProductoId,
                        Cantidad = venta.Cantidad,
                        CategoriaId = venta.Producto?.CategoriaId,
                        stockProducto = stockProducto
                    };

                    return View("Create", ventaModel);
                }
            }
            else
            {
                var errorModel = new ErrorViewModel
                {
                    RequestId = "Producto Inexistente!"
                };
                return View("Error", errorModel);
            }
        }
        [HttpPost]
        public IActionResult Edit(VentaVM ventaModel)
        {

            if (!ModelState.IsValid)
            {
                return View("Create", ventaModel);
            }

            if (!ventaModel.Cantidad.HasValue)
            {
                ModelState.AddModelError("Cantidad", "Debe ingresar la cantidad de productos");
                return View("Create", ventaModel);
            }

            var userID = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            var venta = _ventaBusiness.GetVentaById((int)ventaModel.VentaId);

            var productoId = ventaModel.ProductoId ?? venta.ProductoId;

            var cantidadAnterior = venta.Cantidad;

            var diferenciaCantidad = (int)ventaModel.Cantidad - cantidadAnterior;

            var stockActual = _productoBusiness.GetStock(userID, productoId);

            ventaModel.stockProducto = stockActual;

            if (diferenciaCantidad <= 0 || stockActual >= diferenciaCantidad)
            {
                if (venta == null)
                {
                    return NotFound();
                }

                venta.ProductoId = ventaModel.ProductoId ?? venta.ProductoId;
                venta.Cantidad = (int)ventaModel.Cantidad;

                _ventaBusiness.UpdateVenta(venta);

                return RedirectToAction("Index", "Venta", new { refresh = true });
            }
            else
            {
                ModelState.AddModelError("Cantidad", "La cantidad de venta no puede superar el total disponible en stock.");
                return View("Create", ventaModel);
            }

        }
        [HttpPost]
        public IActionResult Delete(int ventaId)
        {
            _ventaBusiness.DeleteVenta(ventaId);
            return RedirectToAction("Index", new { refresh = true });
        }

        public List<Venta> Filter(int userId, string search, List<Venta> ventasSinfiltro)
        {
            var ventasFiltradas = _ventaBusiness.OptionSelectFilter(search, userId, ventasSinfiltro);

            return ventasFiltradas.ToList();
        }

        public JsonResult GetProductosByCategoria(int categoriaId)
        {
            var productos = _productoBusiness.GetProductosByCategoria(categoriaId);
            return Json(productos.OrderBy(c => c.Nombre).ToList());
        }

        public JsonResult GetStockByProducto(int productoId)
        {
            var userID = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var stock = _productoBusiness.GetStock(userID, productoId);

            return Json(stock);
        }
    }
}

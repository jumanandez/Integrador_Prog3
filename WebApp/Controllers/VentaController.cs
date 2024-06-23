using Microsoft.AspNetCore.Authorization;
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
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    [Authorize]
    public class VentaController : Controller
    {
        private readonly ILogger<VentaController> _logger;

        //Se inyecta las dependencias para usar el business de ejemplo
        private readonly IVentaBusiness _ventaBusiness;
        private readonly IProductoBusiness _productoBusiness;
        private readonly ICategoriaBusiness _categoriaBusiness;
        private readonly IUsuarioBusiness _usuarioBusiness;
        private readonly CompraService _compraService;
        private List<Venta> _currentFiltered = null!;



        public VentaController(IVentaBusiness ventaBusiness,
                               IProductoBusiness productoBusiness,
                               ICategoriaBusiness categoriaBusiness,
                               IUsuarioBusiness usuarioBusiness,
                               ILogger<VentaController> logger,
                               CompraService compraService)
        {
            _logger = logger;
            _ventaBusiness = ventaBusiness;
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

        // GET: VentaController/CreateVenta
        public IActionResult Create()
        {
            var ventaModel = new VentaVM
            {
                VentaId = 0,
                CategoriaLista = _categoriaBusiness.GetAll(),
                ProductoLista = new List<Producto>()
            };
            ModelState.AddModelError("CategoriaId", "(*)Campo obligatorio.");
            return View(ventaModel);
        }

        // POST: VentaController/Create
        [HttpPost]
        public IActionResult Create(VentaVM ventaModel)
        {
            var userID = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            if (ventaModel.CategoriaSeleccionada != 0)
            {
                ventaModel.ProductoLista = _productoBusiness.GetAllWeb()
                    .Where(p => p.CategoriaId == ventaModel.CategoriaSeleccionada)
                    .ToList();
            }            

            if (ventaModel._Producto != null && ventaModel._Producto.ProductoId != 0 && ModelState.IsValid)
            {

                if (_productoBusiness.GetStock(userID, ventaModel._Producto.ProductoId) < ventaModel.Cantidad)
                {
                    ModelState.AddModelError("Cantidad", "La cantidad de venta no puede superar el total disponible en stock.");
                }

                if (ModelState.IsValid && ventaModel.Cantidad == null)
                {
                    ModelState.AddModelError("Cantidad", "Debe ingresar la cantidad de productos");
                }
                else if(ModelState.IsValid && ventaModel.Cantidad != null)
                {
                    var nuevaVenta = new Venta
                    {
                        Fecha = DateTime.Now,
                        ProductoId = ventaModel._Producto.ProductoId,
                        Cantidad = (int)ventaModel.Cantidad,
                        UsuarioId = userID
                    };

                    _ventaBusiness.AddVenta(nuevaVenta);
                    return RedirectToAction("Index", new { refresh = true });
                }


            }

            ventaModel.CategoriaLista = _categoriaBusiness.GetAll();
            return View(ventaModel);

        }

        // GET: VentaController/Edit/5
        public IActionResult Edit(int ventaId)
        {
            var venta = _ventaBusiness.GetVentaById(ventaId);
            if (venta == null)
            {
                return NotFound();
            }

            var ventaModel = new VentaVM
            {
                VentaId = venta.VentaId,
                ProductoId = venta.ProductoId,
                Cantidad = venta.Cantidad,
                CategoriaId = venta.Producto?.CategoriaId,

            };

            return View("Create", ventaModel);
        }

        // POST: VentaController/Edit/5

        [HttpPost]
        public IActionResult Edit(VentaVM ventaModel)
        {

            if (!ModelState.IsValid)
            {
                // Si el modelo no es válido, devolvemos la vista con los errores
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

            if (diferenciaCantidad <= 0 || stockActual >= diferenciaCantidad)
            {
                // Obtener la compra original desde la capa de negocios
                //var venta = _ventaBusiness.GetVentaById((int)ventaModel.VentaId);
                if (venta == null)
                {
                    return NotFound();
                }

                venta.ProductoId = ventaModel.ProductoId ?? venta.ProductoId;  // Manejar el caso de ProductoId nullable
                venta.Cantidad = (int)ventaModel.Cantidad; // Manejar el caso de ProductoCantidad nullable

                _ventaBusiness.UpdateVenta(venta);

                return RedirectToAction("Index", "Venta", new { refresh = true });
            }
            else
            {
                ModelState.AddModelError("Cantidad", "La cantidad de venta no puede superar el total disponible en stock.");
                return View("Create", ventaModel);
            }

        }

        // POST: VentaController/Delete/5
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
    }
}

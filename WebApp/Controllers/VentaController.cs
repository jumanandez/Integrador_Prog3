using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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


        public VentaController(IVentaBusiness ventaBusiness,
                               IProductoBusiness productoBusiness,
                               ICategoriaBusiness categoriaBusiness,
                               IUsuarioBusiness usuarioBusiness,
                               ILogger<VentaController> logger)
        {
            _logger = logger;
            _ventaBusiness = ventaBusiness;
            _productoBusiness = productoBusiness;
            _categoriaBusiness = categoriaBusiness;
            _usuarioBusiness = usuarioBusiness;

        }


        // GET: VentaController
        public IActionResult Index(int pagina = 1, int itemsPorPagina = 5)
        {

            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

           var ViewModel = new VentaVM()
            {           
                Paginado = _ventaBusiness.GetVentasPaginadas(pagina, itemsPorPagina, userId, null)
            };

            return View(ViewModel);
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

            return View(ventaModel);
        }

        // POST: VentaController/Create
        [HttpPost]        
        public IActionResult Create(VentaVM ventaModel)
        {
            var userID = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            if (ventaModel.CategoriaSeleccionada != 0)
            {
                ventaModel.ProductoLista = _productoBusiness.GetAll()
                    .Where(p => p.CategoriaId == ventaModel.CategoriaSeleccionada)
                    .ToList();
            }

            if (ventaModel._Producto != null && ventaModel._Producto.ProductoId != 0 && ModelState.IsValid)
            {

                if (_productoBusiness.GetStock(userID, ventaModel._Producto.ProductoId) < ventaModel.Cantidad)
                {
                    ModelState.AddModelError("Cantidad", "La cantidad de venta no puede superar el total disponible en stock.");
                }

                if (ModelState.IsValid)
                {
                    var nuevaVenta = new Venta
                    {
                        Fecha = DateTime.Now,
                        ProductoId = ventaModel._Producto.ProductoId,
                        Cantidad = (int)ventaModel.Cantidad,
                        UsuarioId = userID
                    };

                    _ventaBusiness.AddVenta(nuevaVenta);
                    return RedirectToAction("Index");
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

            var userID = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            var venta = _ventaBusiness.GetVentaById((int)ventaModel.VentaId);

            var productoId = ventaModel.ProductoId ?? venta.ProductoId;

            var cantidadAnterior = venta.Cantidad;

            var stockActual = _productoBusiness.GetStock(userID, productoId);

            var diferenciaCantidad = (int)ventaModel.Cantidad - cantidadAnterior;

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

                return RedirectToAction("Index", "Venta");
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
            return RedirectToAction("Index");
        }

        
    }
}

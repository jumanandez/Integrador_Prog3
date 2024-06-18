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
        public ActionResult Index()
        {

            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            var ventas = _ventaBusiness.GetVentas(userId);

           var ViewModel = new VentaVM()
            {           
                VentaLista = ventas
            };

            return View(ViewModel);
        }

        // GET: VentaController/Details/5
        public ActionResult Details(int id, int userId)
        {

            var ventas = _ventaBusiness.GetVentas(userId);

            ventas = (from v in ventas
                      where v.VentaId == id
                      
                      select v).ToList();


            var ViewModel = new VentaVM()
            {
                VentaLista = ventas
            };

            return View(ViewModel);
        }
               

        // GET: VentaController/CreateVenta
        public ActionResult Create()
        {
            var ventaModel = new VentaVM
            {
                CategoriaLista = _categoriaBusiness.GetAll(),
                ProductoLista = new List<Producto>()
            };

            return View(ventaModel);
        }

        // POST: VentaController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(VentaVM ventaModel)
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
                        Cantidad = ventaModel.Cantidad,
                        UsuarioId = userID
                    };

                    _ventaBusiness.AddVenta(nuevaVenta);
                    return RedirectToAction("Index");
                }
            }

            ventaModel.CategoriaLista = _categoriaBusiness.GetAll();
            return View(ventaModel);

        }

        // GET: VentaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VentaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


    }
}

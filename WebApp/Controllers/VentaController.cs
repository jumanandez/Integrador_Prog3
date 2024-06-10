using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto.Core.Business;
using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Configurations;
using Proyecto.Core.Data;
using Proyecto.Core.Entities;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    public class VentaController : Controller
    {
        private readonly ILogger<VentaController> _logger;

        //Se inyecta las dependencias para usar el business de ejemplo
        private readonly IVentaBusiness _ventaBusiness;
        private readonly IProductoBusiness _productoBusiness;
        private readonly ICatergoriaBusiness _categoriaBusiness;

        public VentaController(IVentaBusiness ventaBusiness, IProductoBusiness productoBusiness, CategoriaBusiness categoriaBusiness,
                                    ILogger<VentaController> logger)
        {
            _logger = logger;
            _ventaBusiness = ventaBusiness;
            _productoBusiness = productoBusiness;
            _categoriaBusiness = categoriaBusiness;
        }


        // GET: VentaController
        public ActionResult Index(int? CategoriaID, string NombreProducto)
        {

            var ventas = _ventaBusiness.GetVentas();

            
            ventas = (from v in ventas
                      where v.Producto.CategoriaId == CategoriaID.Value
                      where v.Producto.Nombre.ToLower().StartsWith(NombreProducto.ToLower())               
                      select v).ToList();                           
            

            var ViewModel = new VentaVM()
            {
                VentaLista = ventas,
                //CategoriaLista = _categoriaBusiness.GetAll()
            };

            return View(ViewModel);
        }

        // GET: VentaController/Details/5
        public ActionResult Details(int? CategoriaID, int id)
        {

            var ventas = _ventaBusiness.GetVentas();

            ventas = (from v in ventas
                      where v.Producto.CategoriaId == CategoriaID.Value
                      where v.ProductoId == id
                      select v).ToList();


            var ViewModel = new VentaVM()
            {
                VentaLista = ventas
            };

            return View(ViewModel);
        }

        // GET: VentaController/Create
        public ActionResult Create()
        {
            var usuariosID = 1;



            var VentaObj = new Models.ViewModels.VentaVM()
            {
                ProductoLista = _productoBusiness.GetAll(),
                VentaLista = _ventaBusiness.GetVentas()

            };

            return View();
        }

        // POST: VentaController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(Venta venta)
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

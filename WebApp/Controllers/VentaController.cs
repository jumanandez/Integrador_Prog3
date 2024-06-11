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
        private readonly ICategoriaBusiness _categoriaBusiness;

        public VentaController(IVentaBusiness ventaBusiness, IProductoBusiness productoBusiness, ICategoriaBusiness categoriaBusiness,
                                    ILogger<VentaController> logger)
        {
            _logger = logger;
            _ventaBusiness = ventaBusiness;
            _productoBusiness = productoBusiness;
            _categoriaBusiness = categoriaBusiness;
        }


        // GET: VentaController
        public ActionResult Index()
        {

            var ventas = _ventaBusiness.GetVentas();        
                           
            var ViewModel = new VentaVM()
            {
                VentaLista = ventas,
                CategoriaLista = _categoriaBusiness.GetAll()
            };

            return View(ViewModel);
        }

        // GET: VentaController/Details/5
        public ActionResult Details(int id)
        {

            var ventas = _ventaBusiness.GetVentas();

            ventas = (from v in ventas
                      where v.VentaId == id
                      
                      select v).ToList();


            var ViewModel = new VentaVM()
            {
                VentaLista = ventas
            };

            return View(ViewModel);
        }


        // GET: VentaController/CategoriaSelect
        public ActionResult CategoriaSelect()
        {
            
            var CategoriaObj = new Models.ViewModels.VentaVM()
            {

                CategoriaLista = _categoriaBusiness.GetAll(),  
                
            };

            return View(CategoriaObj);
        }

        // POST: VentaController/Create
        [HttpPost]
        public ActionResult CategoriaSelect(VentaVM model)
        {
            try
            {
                var categoriaSeleccionada = model._Producto.CategoriaId;
                return RedirectToAction(nameof(Create), new { categoriaSeleccionada });
            }
            catch
            {
                return View();
            }
        }


        // GET: VentaController/Create
        public ActionResult Create(int categoriaSeleccionada)
        {
            var usuariosID = 2;

            var productoCategoria = (from p in _productoBusiness.GetAll()
                                    where p.CategoriaId == categoriaSeleccionada
                                     select p).ToList();

            var VentaObj = new Models.ViewModels.VentaVM()
            {

                ProductoLista = productoCategoria,
                VentaLista = _ventaBusiness.GetVentas(),
                CategoriaLista = _categoriaBusiness.GetAll()

            };

            return View(VentaObj);
        }

        // POST: VentaController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(VentaVM model)
        {
            try
            {
                var usuariosID = 2;
                

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

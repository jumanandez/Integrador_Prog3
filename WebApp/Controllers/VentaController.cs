using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto.Core.Business;
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
        private readonly ProductoBusiness _productoBusiness;

        public VentaController(ProductoBusiness productoBusiness,
                                    ILogger<VentaController> logger)
        {
            _logger = logger;
            _productoBusiness = productoBusiness;
            
        }


        // GET: VentaController
        public ActionResult Index()
        {
            
            var ViewModel = new VentaVM()
            {
                VentaLista = _productoBusiness.GetVentas()

            };

            return View(ViewModel);
        }

        // GET: VentaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VentaController/Create
        

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

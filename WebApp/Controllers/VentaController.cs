using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Core.Business;
using Proyecto.Core.Configurations;
using Proyecto.Core.Data;
using Proyecto.Core.Entities;

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
            return View(_productoBusiness.GetVentas());            
        }

        // GET: VentaController/Details/5
        public ActionResult Details(int id)
        {          
            return View();
        }

        // GET: VentaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VentaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: VentaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VentaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

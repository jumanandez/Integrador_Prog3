using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Core.Business;
using Proyecto.Core.Configurations;
using Proyecto.Core.Data;
using Proyecto.Core.Entities;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    public class CompraController : Controller
    {
        private readonly ILogger<CompraController> _logger;

        //Se inyecta las dependencias para usar el business de ejemplo
        private readonly ProductoBusiness _productoBusiness;

        public CompraController(ProductoBusiness productoBusiness,
                                    ILogger<CompraController> logger)
        {
            _logger = logger;
            _productoBusiness = productoBusiness;
        }

        // GET: CompraController //peticion para mostrar las compras.
        public ActionResult Index()
        {
            var ViewModel = new CompraVM
            {
                //CompraLista = _productoBusiness.GetCompras()

            };
            return View(ViewModel);            
        }

        
        //public ActionResult DetallesProductos(int id)
        //{
        //    var productos = _productoBusiness.GetAll();

        //    var prodSeleccionado = (from i in productos
        //                               where i.ProductoId == id
        //                               select i).FirstOrDefault();

        //    //retorno a una nueva vista de details para ver el producto.
        //    return View("Detalles Productos",prodSeleccionado);
      
        //}

        
    }
}

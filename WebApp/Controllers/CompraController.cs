using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Proyecto.Core.Business;
using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Configurations;
using Proyecto.Core.Data;
using Proyecto.Core.Entities;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    [Authorize]
    public class CompraController : Controller
    {
        private readonly ILogger<CompraController> _logger;

        //Se inyecta las dependencias para usar el business de ejemplo
        private readonly ICompraBusiness _compraBusiness;
        private readonly IProductoBusiness _productoBusiness;
        private readonly ICategoriaBusiness _categoriaBusiness;
        

        public CompraController(ICompraBusiness compraBusiness, IProductoBusiness productoBusiness, 
                                    ICategoriaBusiness categoriaBusiness,
                                    ILogger<CompraController> logger)
        {
            _logger = logger;
            _compraBusiness = compraBusiness;
            _productoBusiness = productoBusiness;
            _categoriaBusiness = categoriaBusiness;
        }

        // GET: CompraController 

        public ActionResult Index()
        {

            var ViewModel = new CompraVM()
            {
                CompraLista = _compraBusiness.GetCompras()
            };

            return View(ViewModel);

        }

        [HttpGet]
        public IActionResult Details()
        {

            var compras = _compraBusiness.GetCompras();

            compras = (from c in compras
                       where c.Producto.CategoriaId == 1 && c.ProductoId == 10
                       //where c.ProductoId == 10
                       select c).ToList();

            var ViewModel = new CompraVM
            {
                CompraLista = compras
            };

            return View(ViewModel);

        }

        [HttpPost]
        public IActionResult Details(CompraVM compraVM)
        {

            if (compraVM._Compra.CompraId != 0)
            {
                _compraBusiness.AddCompra(compraVM._Compra);
                return RedirectToAction("Index");
            }

            return View(compraVM);

        }

        // GET: CompraController/CategoriaSelect
        public ActionResult CategoriaSelect()
        {
            var CategoriaObj = new CompraVM()
            { 
                CategoriaLista = _categoriaBusiness.GetAll(),
            };

            return View(CategoriaObj);
        }

        // POST: compraController/Create
        [HttpPost]
        public ActionResult CategoriaSelect(CompraVM model)
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

        // GET: compraController/Create
        public ActionResult Create(int categoriaSeleccionada)
        {
            //var usuariosID = 1;

            var productoCategoria = (from p in _productoBusiness.GetAll()
                                     where p.CategoriaId == categoriaSeleccionada
                                     select p).ToList();

            var CompraObj = new CompraVM()
            {

                ProductoLista= productoCategoria,
                CompraLista = _compraBusiness.GetCompras(),
                CategoriaLista = _categoriaBusiness.GetAll()


            };

            return View(CompraObj);
        }

        // POST: compraController/Create
        [HttpPost]
        public ActionResult Create(CompraVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _compraBusiness.AddCompra(model._Compra);
                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }
    }


}

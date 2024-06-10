﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyecto.Core.Business;
using Proyecto.Core.Business.Interfaces;
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
        private readonly ICompraBusiness _compraBusiness;

        public CompraController(ICompraBusiness compraBusiness,
                                    ILogger<CompraController> logger)
        {
            _logger = logger;
            _compraBusiness = compraBusiness;
        }

        // GET: CompraController 

        public ActionResult Index(int? CategoriaId, string NombreProducto)
        {

            var compras = _compraBusiness.GetCompras();


            compras = (from v in compras
                       where v.Producto.CategoriaId == CategoriaId.Value
                       where v.Producto.Nombre.ToLower().StartsWith(NombreProducto.ToLower())
                       select v).ToList();


            var ViewModel = new CompraVM()
            {
                CompraLista = compras
            };

            return View(ViewModel);


        }

        public IActionResult Details(int? CategoriaId, int id)
        {
            var compras = _compraBusiness.GetCompras();

            compras = (from c in compras
                       where c.Producto.CategoriaId == CategoriaId.Value
                       where c.ProductoId == id
                       select c).ToList();

            var ViewModel = new CompraVM
            {

                CompraLista = compras

            };

            return View(ViewModel);

        }


        //Get  compra/create
        public IActionResult Create()
        {

            var CompraNueva = new Models.ViewModels.CompraVM()
            {

                CompraLista = _compraBusiness.GetCompras()
            };


            return View(CompraNueva);
        }

        //post compra/create
        //[HttpPost]
        //public async Task<IActionResult> Create(CompraVM compraModel)
        //{
        //if (ModelState.IsValid)
        //{
        //    var compra = new Compra
        //    {
        //        ProductoId = compraModel._Compra.ProductoId,
        //        Fecha = compraModel._Compra.Fecha,
        //        Cantidad = compraModel._Compra.Cantidad,
        //        UsuarioId = 1 // Ajusta esto según el usuario actual
        //    };

        //    _compraBusiness.AddCompra(compra);
        //    await _compraBusiness.SaveChangesAsync();

        //    return RedirectToAction(nameof(Index));
        //}

        //// Si el modelo no es válido, vuelve a cargar la lista de productos
        //compraModel.ProductoLista = _productoBusiness.GetAll().ToList();
        //return View(viewModel);
        // }




    }
}

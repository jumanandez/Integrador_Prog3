﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Core.Business;
using Proyecto.Core.Entities;

namespace Web_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductoController : ControllerBase
	{
		private readonly ILogger<ProductoController> _logger;
		
		//Se inyecta las dependencias para usar el business de ejemplo
		private readonly ProductoBusiness _productoBusiness;

		public ProductoController(ProductoBusiness productoBusiness,
									ILogger<ProductoController> logger)
		{
			_logger = logger;
			_productoBusiness = productoBusiness;
		}

		// Acá probé que funcione la conexion, lo pueden borrar si quieren

		[HttpGet]
		[Route("Lista")]
		public List<Producto> GetAll()
		{
			var products = new List<Producto>();
			
			products = _productoBusiness.GetAll();

			return products;
			
        }

		[HttpGet]
		[Route("Producto/{ProductoId:int}")]
		public Producto Get(int id)
		{
			Producto producto = _productoBusiness.GetProducto(id);

			return producto;
		}

	
		[HttpDelete]
		[Route("Eliminar/{ProductoId:int}")]
		public void Eliminar(int ProductoId)
		{
			_productoBusiness.DeleteProducto(ProductoId);
		}




	}
}

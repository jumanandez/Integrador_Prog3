using Microsoft.AspNetCore.Http;
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
		
		[HttpGet(Name = "GetProductos")]
		public IEnumerable<Producto> Get()
		{
			var productos = _productoBusiness.GetAll();

			return productos;
		}
	}
}

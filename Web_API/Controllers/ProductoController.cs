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

		//Se inyecta las dependencias para usar el business
		private readonly ProductoBusiness _productoBusiness;

		public ProductoController(ProductoBusiness productoBusiness,
									ILogger<ProductoController> logger)
		{
			_logger = logger;
			_productoBusiness = productoBusiness;
		}


		[HttpGet]
		[Route("/{usuarioId:int}/user/{productoId:int}/stock")]
		public int GetStock(int usuarioId, int productoId)
		{
			return _productoBusiness.GetStock(usuarioId, productoId);
		}

	
		



	}
}

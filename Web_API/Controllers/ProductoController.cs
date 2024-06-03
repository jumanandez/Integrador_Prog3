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


		[HttpGet]
		[Route("/{UsuarioId:int}/user/{ProductoId:int}/stock")]
		public int GetStock(int UsuarioId, int ProductoId)
		{
			int compras = (from c in _productoBusiness.GetCompras()
						  where c.ProductoId == ProductoId && c.UsuarioId == UsuarioId
						  select c.Cantidad).Sum();

			int ventas = (from v in  _productoBusiness.GetVentas()
						  where v.ProductoId == ProductoId && v.UsuarioId == UsuarioId
						  select v.Cantidad).Sum();

			int stock = compras - ventas;
						

			return stock;
		}

	
		



	}
}

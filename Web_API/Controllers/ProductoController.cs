using Microsoft.AspNetCore.Mvc;
using Proyecto.Core.Business;
using Proyecto.Core.Business.Interfaces;
using System.Security.Claims;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoBusiness _productoBusiness;

        public ProductoController(IProductoBusiness productoBusiness)
        {
            _productoBusiness = productoBusiness;
        }

        [HttpGet]
        [Route("/user/{productoId:int}/stock")]
        public IActionResult GetStock(int productoId)
        {
            var producto = _productoBusiness.GetProducto(productoId);

            if (producto == null)
            {
                return NotFound(new { Message = "Producto no encontrado" });
            }

            var stock = _productoBusiness.GetStock(productoId);

            var result = new
            {
                ProductoId = productoId,
                Nombre = producto.Nombre,
                Stock = stock
            };

            return Ok(result);
        }
    }
}


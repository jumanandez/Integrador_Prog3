using Proyecto.Core.Configurations;
using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Data
{

	public class ProjectRepository
	{
		private readonly Config _config;

		public ProjectRepository(Config config)
		{
			_config = config;
		}
		public void AddProducto(Producto product)
		{
			
			using (var dbcontext = new IntegradorProg3Context(_config))
			{
				dbcontext.Add(product);

				dbcontext.SaveChanges();
			}

		}

		public List<Producto> GetProductos()
		{
			var productos = new List<Producto>();

			using (var dbcontext = new IntegradorProg3Context(_config))
			{

				productos = dbcontext.Productos.ToList();

				
			}
			return productos;
		}

		public List<Compra> GetCompras()
		{
			var compras = new List<Compra>();

			using (var dbcontext = new IntegradorProg3Context(_config))
			{
				compras = dbcontext.Compras.ToList();
			}
			return compras;
		}

		public List<Venta> GetVentas() 
		{
            var ventas = new List<Venta>();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                ventas = dbcontext.Venta.ToList();
            }
            return ventas;
        }

		public Producto GetProducto(int id)
		{
			var producto = new Producto();

			using (var dbcontext = new IntegradorProg3Context(_config))
			{
				producto = dbcontext.Productos.Find(id);
			}
			return producto;
		}

		public void DeleteProducto(int id)
		{
			var producto = new Producto();

			using(var dbcontext = new IntegradorProg3Context(_config))
			{
				producto = dbcontext.Productos.Find(id);
				dbcontext.Remove(producto);
				dbcontext.SaveChanges();
			}
		}
	}
}

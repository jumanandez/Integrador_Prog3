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

		public List<Categoria> GetCategorias()
		{
			var categorias = new List<Categoria>();

			using (var dbcontext = new IntegradorProg3Context(_config))
			{

				categorias = dbcontext.Categoria.ToList();
			}

			return categorias;

		}

		
		public bool PostCategoría(Categoria categoria)
		{
			using (var dbcontext = new IntegradorProg3Context(_config))
			{

				dbcontext.Categoria.Add(categoria);

				dbcontext.SaveChanges();

			}

			return true;
		}
	}
}

using Proyecto.Core.Configurations;
using Proyecto.Core.Data.Interfaces;
using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Data
{

	public class ProjectRepository : IProjectRepository
	{
		private readonly Config _config;

		public ProjectRepository(Config config)
		{
			_config = config;
		}

		#region Region Producto
		public void AddProducto(Producto product)
		{
			
			using (var dbcontext = new IntegradorProg3Context(_config))
			{
				dbcontext.Add(product);

				dbcontext.SaveChanges();
			}

		}
        public void DeleteProducto(Producto product)
        {

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                dbcontext.Remove(product);

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
        public List<string> GetAllNames()
        {
            var productos = new List<Producto>();
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                List<string> names = dbcontext.Productos
                                                        .Select(p => p.Nombre)
                                                        .ToList();
                return names;
            }
        }
        public void ModifyProduct(Producto product)
        {

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
				dbcontext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                dbcontext.SaveChanges();
            }

        }
        #endregion

        #region Region Categoria
        public List<Categoria> GetCategorias()
		{
			var categorias = new List<Categoria>();

			using (var dbcontext = new IntegradorProg3Context(_config))
			{

				categorias = dbcontext.Categoria.ToList();
			}

			return categorias;

		}
		public bool AddCategoría(Categoria categoria)
		{
			using (var dbcontext = new IntegradorProg3Context(_config))
			{

				dbcontext.Categoria.Add(categoria);

				dbcontext.SaveChanges();

			}

			return true;
		}
        #endregion
    }
}

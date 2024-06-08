using Microsoft.EntityFrameworkCore;
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
                categorias = dbcontext.Categoria.Include(ct => ct.Productos).ToList();
            }
            return categorias;
        }

        public List<Compra> GetCompras()
		{
			var compras = new List<Compra>();

			using (var dbcontext = new IntegradorProg3Context(_config))
			{
				compras = dbcontext.Compras.Include(c => c.Producto).Include(c => c.Usuario).ToList();
			}
			return compras;
		}       

        #region REPOSITORY DE VENTAS
        public List<Venta> GetVentas() 
		{
            var ventas = new List<Venta>();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                ventas = dbcontext.Venta.Include(v => v.Producto).Include(v => v.Usuario).ToList();
            }
            return ventas;
        }

		public void AddVenta(Venta venta)
		{

			using (var dbcontext = new IntegradorProg3Context(_config))
			{
				dbcontext.Add(venta);

				dbcontext.SaveChanges();
			}

		}

        public void DeleteVenta(int id)
        {
            var venta = new Venta();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                venta = dbcontext.Venta.Find(id);
                dbcontext.Remove(venta);
                dbcontext.SaveChanges();
            }
        }

        #endregion

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

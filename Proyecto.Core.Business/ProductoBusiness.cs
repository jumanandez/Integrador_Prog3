using Proyecto.Core.Entities;
using Proyecto.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Core.Configurations;
using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Data.Interfaces;

namespace Proyecto.Core.Business
{
	public class ProductoBusiness : IProductoBusiness
    {
		private readonly IProjectRepository _projectRepository;

		public ProductoBusiness(IProjectRepository projectRepository)
		{
			_projectRepository = projectRepository;
		}

		public void AddProducto(Producto producto)
		{
			 _projectRepository.AddProducto(producto);
		}

        public void DeleteProducto(Producto product)
		{
			_projectRepository.DeleteProducto(product);
		}

        public void ModifyProduct(Producto product)
		{
			_projectRepository.ModifyProduct(product);
		}


        public List<Producto> GetAll()
		{
			return _projectRepository.GetProductos();
		}


        public Producto GetProducto(int id)
		{
			return _projectRepository.GetProducto(id);
		}

		public void DeleteProducto(int id)
		{
			_projectRepository.DeleteProducto(id);
		}

		public int GetStock(int usuarioId, int productoId)
		{
			return _projectRepository.GetStock(usuarioId, productoId);
		}

		public List<Producto> GetProductosByCategoria(int categoriaId)
		{
			return _projectRepository.GetProductosByCategoria(categoriaId);
		}
    
		public List<string> GetAllNames()
		{
			return _projectRepository.GetAllNames();

		}
        public Paginado<Producto> GetProductosPaginados(int pagina, int itemsPorPagina)
        {
			var producto = _projectRepository.GetProductos()
                .Skip((pagina - 1) * itemsPorPagina)
                .Take(itemsPorPagina)
                .ToList();

            var totalProductos = _projectRepository.GetProductos().Count();

            return new Paginado<Producto>
            {
                Items = producto,
                PaginaActual = pagina,
                ItemsPorPagina = itemsPorPagina,
                TotalPaginas = (int)Math.Ceiling(totalProductos / (double)itemsPorPagina)
            };
        }
    }
}
﻿using Proyecto.Core.Entities;
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

        public void ModifyProduct(Producto product, int categoriaId)
        {
			_projectRepository.ModifyProduct(product, categoriaId);
		}


        public List<Producto> GetAll()
		{
			return _projectRepository.GetProductos();
		}

        public List<Producto> GetAllWeb()
        {
            return _projectRepository.GetProductosWeb();
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

		public int GetStock(int productoId)
		{
			return _projectRepository.GetStock(productoId);
		}

		public List<Producto> GetProductosByCategoria(int categoriaId)
		{
			return _projectRepository.GetProductosByCategoria(categoriaId);
		}
    
		public List<string> GetAllNames()
		{
			return _projectRepository.GetAllNames();

		}
        public Paginado<Producto> GetProductosPaginados(int pagina, int itemsPorPagina, List<Producto>? List)
        {
			var producto = _projectRepository.GetProductos()
                .Skip((pagina - 1) * itemsPorPagina)
                .Take(itemsPorPagina)
                .ToList();

            List<Producto> productoList = List ?? _projectRepository.GetProductos();

            int totalProductos = productoList.Count;

            List<Producto> comprasPaginadas = productoList
                .Skip((pagina - 1) * itemsPorPagina)
                .Take(itemsPorPagina)
                .ToList();


            return new Paginado<Producto>()
            {
                Items = comprasPaginadas,
                PaginaActual = pagina,
                ItemsPorPagina = itemsPorPagina,
                TotalPaginas = (int)Math.Ceiling(totalProductos / (double)itemsPorPagina),
                HasPreviousPage = pagina > 1,
                HasNextPage = pagina < (int)Math.Ceiling(totalProductos / (double)itemsPorPagina),
            };
        }
    }
}
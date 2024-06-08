using Proyecto.Core.Entities;
using Proyecto.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Core.Configurations;
using Proyecto.Core.Business.Interfaces;

namespace Proyecto.Core.Business
{
	public class ProductoBusiness : IProductoBusiness
    {
		private readonly ProjectRepository _projectRepository;

		public ProductoBusiness(ProjectRepository projectRepository)
		{
			_projectRepository = projectRepository;
		}

		public void AddProducto(Producto producto)
		{
			 _projectRepository.AddProducto(producto);
		}

		public List<Producto> GetAll()
		{
			return _projectRepository.GetProductos();
		}
	}
}

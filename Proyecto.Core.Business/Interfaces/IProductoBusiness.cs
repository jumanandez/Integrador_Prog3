using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Business.Interfaces
{
    public interface IProductoBusiness
    {
        public List<Producto> GetAll();
        public Producto GetProducto(int id);
        public void AddProducto(Producto producto);
        public void DeleteProducto(int id);
        public List<Producto> GetProductosByCategoria(int categoriaId);
        public void DeleteProducto(Producto product);
        public void ModifyProduct(Producto product);
        public List<string> GetAllNames();
		public int GetStock(int usuarioId, int productoId);
	}
}

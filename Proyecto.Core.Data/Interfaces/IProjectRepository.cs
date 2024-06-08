using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Data.Interfaces
{
    public interface IProjectRepository
    {
        public void AddProducto(Producto product);
        public void DeleteProducto(Producto product);
        public List<Producto> GetProductos();
        public List<string> GetAllNames();
        public List<Categoria> GetCategorias();
        public void ModifyProduct(Producto product);
        public bool AddCategoría(Categoria categoria);
    }
}

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
        public List<Producto> GetProductos();
        public List<Categoria> GetCategorias();
        public bool AddCategoría(Categoria categoria);
    }
}

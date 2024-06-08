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
        public void AddProducto(Producto producto);
        public void DeleteProducto(Producto product);
        public void ModifyProduct(Producto product);
        public List<string> GetAllNames();
    }
}

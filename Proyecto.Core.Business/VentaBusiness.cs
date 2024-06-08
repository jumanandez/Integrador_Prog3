using Proyecto.Core.Entities;
using Proyecto.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Core.Configurations;

namespace Proyecto.Core.Business
{
    public class VentaBusiness
    {
        private readonly ProjectRepository _projectRepository;

        public VentaBusiness(ProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public void AddVenta(Venta venta)
        {
            _projectRepository.AddVenta(venta);
        }

        public List<Producto> GetAll()
        {
            return _projectRepository.GetProductos();
        }

        public List<Compra> GetCompras()
        {
            return _projectRepository.GetCompras();
        }

        public List<Venta> GetVentas()
        {
            return _projectRepository.GetVentas();
        }


        public Producto GetProducto(int id)
        {
            return _projectRepository.GetProducto(id);
        }

        public void DeleteVenta(int id)
        {
            _projectRepository.DeleteVenta(id);
        }
    }
}

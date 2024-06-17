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
    public class VentaBusiness : IVentaBusiness
    {
        private readonly IProjectRepository _projectRepository;

        public VentaBusiness(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public void AddVenta(Venta venta)
        {
            _projectRepository.AddVenta(venta);
        }

        public List<Venta> GetVentas(int userId)
        {
            return _projectRepository.GetVentas(userId);
        }

        public void DeleteVenta(int id)
        {
            _projectRepository.DeleteVenta(id);
        }

    }
}

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

        public int GetVentaProducto(int userId, int productoId)
        {
            return _projectRepository.GetVentaProducto(userId, productoId);
        }

        public Paginado<Venta> GetVentasPaginadas(int pagina, int itemsPorPagina, int usuarioId, List<Venta>? ventas)
        {
            List<Venta> ventaSelect = ventas == null ? _projectRepository.GetVentas(usuarioId) : ventas;

            var ventasPaginada = ventaSelect
                .Skip((pagina - 1) * itemsPorPagina)
                .Take(itemsPorPagina)
                .ToList();

            var totalVentas = ventaSelect.Count();

            return new Paginado<Venta>()
            {
                Items = ventasPaginada,
                PaginaActual = pagina,
                ItemsPorPagina = itemsPorPagina,
                TotalPaginas = (int)Math.Ceiling(totalVentas / (double)itemsPorPagina)
            };
        }

        public void DeleteVenta(int id)
        {
            _projectRepository.DeleteVenta(id);
        }

        public Venta GetVentaById(int id)
        {
            return _projectRepository.GetVentaById(id);
        }

        public void UpdateVenta(Venta venta)
        {
            _projectRepository.UpdateVenta(venta);
        }
    }
}

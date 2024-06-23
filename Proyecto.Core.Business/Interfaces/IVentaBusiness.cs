using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Business.Interfaces
{
    public interface IVentaBusiness
    {
        public void AddVenta(Venta venta);

        public void DeleteVenta(int id);

        public Paginado<Venta> GetVentasPaginadas(int pagina, int itemsPorPagina, int usuarioId, List<Venta>? ventas);

        public List<Venta> GetVentas(int userId);
        public int GetVentaProducto(int userId, int productoId);

        public List<Venta> OptionSelectFilter(string search, int userId, List<Venta>? ventasList);

        public Venta GetVentaById(int id);

        public void UpdateVenta(Venta venta);
    }
}

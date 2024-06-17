using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Business.Interfaces
{
    public interface ICompraBusiness
    {
        public void AddCompra(Compra compra);

        public Compra GetCompraById(int id);

        public void DeleteCompra(int id);

        public List<Compra> GetCompras(int usuarioId);

        public bool VerificarFecha(DateTime fecha);

        public Paginado<Compra> GetComprasPaginadas(int pagina, int itemsPorPagina, int usuarioId);

        public void UpdateCompra(Compra compra);


    }
}

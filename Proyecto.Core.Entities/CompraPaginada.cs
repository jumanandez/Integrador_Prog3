using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Entities
{
    public class CompraPaginada
    {
        public List<Compra> Compras { get; set; }
        public int PaginaActual { get; set; }
        public int TotalPaginas { get; set; }
        public int ItemsPorPagina { get; set; }
    }
}

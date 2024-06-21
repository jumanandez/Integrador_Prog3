using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Entities
{
    public class Paginado<T>
    {
        public List<T>? Items { get; set; }
        public int PaginaActual { get; set; }
        public int TotalPaginas { get; set; }
        public int ItemsPorPagina { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }

        //public Paginado(List<T> items, int count, int pageIndex, int pageSize)
        //{
        //    PaginaActual = pageIndex;
        //    TotalPaginas = (int)Math.Ceiling(count / (double)pageSize);
        //    this.Items = items.ToList();

        //}
        //public static Paginado<T> Create(List<T> source, int pageIndex, int pageSize)
        //{
        //    var count = source.Count();
        //    var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        //    return new Paginado<T>(items, count, pageIndex, pageSize);
        //}
    }
}

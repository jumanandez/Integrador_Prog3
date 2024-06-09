using Proyecto.Core.Entities;

namespace WebApp.Models.ViewModels
{
    public class CompraVM
    {        
        public List<Compra> CompraLista { get; set; }

        public Compra _Compra { get; set; }

        public List<Producto> ProductoLista { get; set; }

        public Producto _Producto {  get; set; }

        public List<Categoria> CategoriaLista { get; set; }

        public Categoria _Categoria { get; set; }
    }
}

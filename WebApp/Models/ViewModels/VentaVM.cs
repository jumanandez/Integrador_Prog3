using Proyecto.Core.Entities;

namespace WebApp.Models.ViewModels
{
    public class VentaVM
    {        
        public List<Venta>? VentaLista { get; set; }

        public Venta? _Venta { get; set; }

        public List<Producto>? ProductoLista { get; set; }

        public Producto? _Producto {  get; set; }       

        public List<Categoria>? CategoriaLista { get; set; }

        public Categoria? _Categoria { get; set; }

        public int Cantidad { get; set; }

        public int CategoriaSeleccionada { get; set; }

    }
}

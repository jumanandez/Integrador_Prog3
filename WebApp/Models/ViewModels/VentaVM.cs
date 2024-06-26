﻿using Proyecto.Core.Entities;

namespace WebApp.Models.ViewModels
{
    public class VentaVM
    {        
        public List<Venta>? VentaLista { get; set; }

        public Venta? _Venta { get; set; }

        public List<Producto>? ProductoLista { get; set; }

        public Producto? _Producto {  get; set; }       

        public List<Categoria>? CategoriaLista { get; set; }

        public int? Cantidad { get; set; }

        public int CategoriaSeleccionada { get; set; }

        public Paginado<Venta>? Paginado { get; set; }

        public int? VentaId { get; set; }

        public int? CategoriaId { get; set; }

        public int? ProductoId { get; set; }

        public int Llamado { get; set; } = 0; //0 = nueva venta, 1 = editar.

        public int? stockProducto {  get; set; }
      
        public List<Compra>? CompraLista { get; set; }

    }
}

﻿using Proyecto.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.ViewModels
{
    public class CompraVM
    {
        public int? FilterOption { get; set; }
        public List<Compra>? CompraLista { get; set; }

        public Paginado<Compra>? Paginado { get; set; }

        public int? CompraId { get; set; }
        public int? ProductoId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor que cero")]
        public int? ProductoCantidad { get; set; }

        public Compra? _Compra { get; set; }

        public List<Producto>? ProductoLista { get; set; }

        public Producto? _Producto { get; set; }

        public List<Categoria>? CategoriaLista { get; set; }

        public Categoria? _Categoria { get; set; }

       
        public int? CategoriaId { get; set; }

        public string? NombreProducto { get; set; }


        public DateTime? FechaCompra { get; set; }

        public int Llamado { get; set; } = 0; //0 = nueva compra, 1 = editar, 2 = repetir compra

        public List<Venta>? VentaLista { get; set; }

        public Venta? _Venta { get; set; }
    }


}
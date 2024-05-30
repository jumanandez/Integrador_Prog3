using System;
using System.Collections.Generic;

namespace WinForm;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string Nombre { get; set; } = null!;

    public int CategoriaId { get; set; }

    public bool Habilitado { get; set; }

    public virtual Categorium Categoria { get; set; } = null!;

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}

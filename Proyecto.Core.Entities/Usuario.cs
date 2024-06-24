using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace Proyecto.Core.Entities;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string Nombre { get; set; } = null!;

    public byte[] HashPassword { get; set; } = null!;

    public byte[] Salt { get; set; } = null!;

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();


}

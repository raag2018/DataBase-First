using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }

    public string Categoria { get; set; } = null!;

    public bool Estado { get; set; }
}

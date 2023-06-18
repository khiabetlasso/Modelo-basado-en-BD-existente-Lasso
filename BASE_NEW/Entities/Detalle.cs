using System;
using System.Collections.Generic;

namespace BASE_NEW.Entities;

public partial class Detalle
{
    public int Id { get; set; }

    public int Cantidad { get; set; }

    public double Precio { get; set; }

    public int CompraEncabezadoid { get; set; }

    public int Productoid { get; set; }

    public virtual Producto Producto { get; set; } = null!;
}

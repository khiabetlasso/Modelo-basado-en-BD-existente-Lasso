﻿using System;
using System.Collections.Generic;

namespace BASE_NEW.Entities;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public double PrecioCompra { get; set; }

    public double PrecioVenta { get; set; }

    public int Cantidad { get; set; }

    public int Categoriaid { get; set; }

    public virtual ICollection<Detalle> Detalles { get; set; } = new List<Detalle>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}

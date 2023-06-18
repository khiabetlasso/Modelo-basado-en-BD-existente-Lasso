using System;
using System.Collections.Generic;

namespace BASE_NEW;

public partial class Factura
{
    public int Id { get; set; }

    public int Productoid { get; set; }

    public int Ventaid { get; set; }

    public int Cantidad { get; set; }

    public double Precio { get; set; }

    public double TotalXproducto { get; set; }

    public virtual Producto Producto { get; set; } = null!;
}

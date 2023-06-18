using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BASE_NEW;

public partial class FacturaContext : DbContext
{
    public FacturaContext()
    {
    }

    public FacturaContext(DbContextOptions<FacturaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Detalle> Detalles { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:Conexion");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.ToTable("cliente");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CorreoElectronico).HasColumnName("correo_electronico");
            entity.Property(e => e.Direccion).HasColumnName("direccion");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
        });

        modelBuilder.Entity<Detalle>(entity =>
        {
            entity.ToTable("detalle");

            entity.HasIndex(e => e.Productoid, "IX_detalle_productoid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.CompraEncabezadoid).HasColumnName("compra_encabezadoid");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.Productoid).HasColumnName("productoid");

            entity.HasOne(d => d.Producto).WithMany(p => p.Detalles).HasForeignKey(d => d.Productoid);
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.ToTable("factura");

            entity.HasIndex(e => e.Productoid, "IX_factura_productoid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.Productoid).HasColumnName("productoid");
            entity.Property(e => e.TotalXproducto).HasColumnName("totalXproducto");
            entity.Property(e => e.Ventaid).HasColumnName("ventaid");

            entity.HasOne(d => d.Producto).WithMany(p => p.Facturas).HasForeignKey(d => d.Productoid);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.ToTable("producto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Categoriaid).HasColumnName("categoriaid");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
            entity.Property(e => e.PrecioCompra).HasColumnName("precio_compra");
            entity.Property(e => e.PrecioVenta).HasColumnName("precio_venta");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

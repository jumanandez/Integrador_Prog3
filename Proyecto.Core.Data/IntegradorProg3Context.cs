using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinForm;

public partial class IntegradorProg3Context : DbContext
{
    public IntegradorProg3Context()
    {
    }

    public IntegradorProg3Context(DbContextOptions<IntegradorProg3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.CategoriaId).HasName("PK__Categori__F353C1E5432C83E0");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.CompraId).HasName("PK__Compra__067DA74597667150");

            entity.ToTable("Compra");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.Producto).WithMany(p => p.Compras)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Compra_Producto");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Compras)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Compra_Usuario");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__Producto__A430AEA3EA589C10");

            entity.ToTable("Producto");

            entity.Property(e => e.Habilitado).HasDefaultValue(true);
            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasOne(d => d.Categoria).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Producto_Categoria");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuario__2B3DE7B80EA87425");

            entity.ToTable("Usuario");

            entity.Property(e => e.HashPassword).HasMaxLength(256);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Salt).HasMaxLength(16);
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => e.VentaId).HasName("PK__Venta__5B4150ACB87417E5");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.Producto).WithMany(p => p.Venta)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Venta_Producto");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Venta)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Venta_Usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

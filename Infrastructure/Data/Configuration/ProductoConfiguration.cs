using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        //definimos las propiedades de la entidad
        builder.ToTable("Productos");

        builder.Property(p => p.IdProducto)
        .HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .IsRequired();

        builder.Property(p => p.NombreProducto)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Precio)
        .IsRequired()
        .HasColumnType("decimal");

        builder.Property(p => p.StockMinimo)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.StockMaximo)
        .IsRequired()
        .HasColumnType("int");

    }
}

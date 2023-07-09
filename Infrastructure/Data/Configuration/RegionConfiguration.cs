using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class RegionConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.ToTable("Regiones");

        builder.Property(p => p.codRegion)
        .IsRequired()
        //.HasAnnotation("MySql : ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasMaxLength(3);

        builder.Property(p => p.nombreRegion)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasIndex(p => p.nombreRegion)
        .IsUnique();

        //Definimos la FOREIGN KEY
        builder.HasOne(p => p.Estado)
        .WithMany(p => p.Regiones)
        .HasForeignKey(p => p.codEstado)
        .IsRequired();
        
    }
}

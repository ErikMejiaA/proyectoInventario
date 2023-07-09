using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data;

public class proyectoInventarioContext : DbContext
{
    public proyectoInventarioContext(DbContextOptions<proyectoInventarioContext> options) : base(options)
    {
        
    }

    //aqui van referencias de las entidades creadas
    public DbSet<Region> ? Regiones { get; set; }
    public DbSet<Pais> ? Paises { get; set; }
    public DbSet<Estado> ? Estados { get; set; } 
       
    //metodo para cargar de forma automatica las entidades y configuraciones de estas en la base de datos creada 
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
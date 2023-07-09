using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Estado
{
    //Definimos los atribuctos de cada una de las entidades
    [Key] //se define la llave Primaria codEstado
    public string ? codEstado { get; set; }
    public string ? nombreEstado { get; set; }

    public string ? codPais { get; set; }

    //Definimos sus ICollection
    public ICollection<Region> ? Regiones { get; set; }

    //Definimos una referencia a la entidad Pais
    public Pais ? Pais { get; set; }

        
}

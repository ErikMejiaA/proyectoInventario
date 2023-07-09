using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Pais
{
    //Definimos los atribuctos de cada una de las entidades
    [Key]   //se define la llave Primaria codPais
    public string ? codPais { get; set; }
    public string ? nombrePais { get; set; }

    //definimos las ICollection
    public ICollection<Estado> ? Estados { get; set;}


}

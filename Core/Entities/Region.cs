using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Region
{
    //Definimos los atribuctos de cada una de las entidades
    //[Key]   //se define la llave Primaria codRegion
    public string ? codRegion { get; set; }
    public string ? nombreRegion { get; set; }
    public string ? codEstado { get; set; }

    //Definimos una referencia a la entidad Estado
    public Estado ? Estado { get; set;}

        
}

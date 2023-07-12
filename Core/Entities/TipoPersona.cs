namespace Core.Entities;

public class TipoPersona
{
    //definimos los atributos de la entidad
    public int Id { get; set; }
    public string ? Descripcion { get; set; }

    //definimos los ICollection a la entidad
    public ICollection<Persona> ? Personas { get; set; }
    

        
}

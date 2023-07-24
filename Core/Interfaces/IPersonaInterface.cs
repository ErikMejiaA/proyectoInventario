
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IPersonaInterface
{
    //implemetacion de los metodos 
    Task<Persona> GetByIdAsync(string id);
    Task<IEnumerable<Persona>> GetAllAsync();
    IEnumerable<Persona> find(Expression<Func<Persona, bool>> expression);
    void Add(Persona entity);
    void AddRange(IEnumerable<Persona> entities);
    void Remove(Persona entity);
    void RemoveRange(IEnumerable<Persona> entities);
    void Update(Persona entity);
    

}

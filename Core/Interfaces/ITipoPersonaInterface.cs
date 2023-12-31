using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;
public interface ITipoPersonaInterface
{
    //implemtacion de los metodos 
    Task<TipoPersona> GetByIdAsync(int id);
    Task<IEnumerable<TipoPersona>> GetAllAsync();
    IEnumerable<TipoPersona> Find(Expression<Func<TipoPersona, bool>> expression);
    
    void Add(TipoPersona entity);
    void AddRange(IEnumerable<TipoPersona> entities);
    void Remove(TipoPersona entity);
    void RemoveRange(IEnumerable<TipoPersona> entities);
    void Update(TipoPersona entity);
        
}

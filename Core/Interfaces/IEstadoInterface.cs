using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IEstadoInterface
{
    //implemetacion de los metodos 
    Task<Estado> ? GetByIdAsycn(string id);
    Task<IEnumerable<Estado>> GetAllAsync();
    IEnumerable<Estado> Find(Expression<Func<Estado, bool>> expression);
    void Add(Estado entity);
    void AddRange(IEnumerable<Estado> entities);
    void Remove(Estado entity);
    void RemoveRange(IEnumerable<Estado> entities);
    void Update(Estado entity);
}

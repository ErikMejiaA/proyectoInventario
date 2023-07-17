using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IProductoInterface
{
    //implementamos los metodos
    Task<Producto> GetByIdAsync(string id);
    Task<IEnumerable<Producto>> GetAllAsync();
    IEnumerable<Producto> Find(Expression<Func<Producto, bool>> expression);
    void Add(Producto entity);
    void AddRange(IEnumerable<Producto> entities);
    void Remove(Producto entity);
    void RemoveRange(IEnumerable<Producto> entities);
    void Update(Producto entity);
        
}

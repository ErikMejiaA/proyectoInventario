using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class EstadoRepository : IEstadoInterface
{
    //variable de context
    protected readonly proyectoInventarioContext _context;

    //constructor
    public EstadoRepository(proyectoInventarioContext context)
    {
        _context = context;
    }

    public void Add(Estado entity)
    {
        _context.Set<Estado>().Add(entity);
    }

    public void AddRange(IEnumerable<Estado> entities)
    {
        _context.Set<Estado>().AddRange(entities);
    }

    public IEnumerable<Estado> Find(Expression<Func<Estado, bool>> expression)
    {
        return _context.Set<Estado>().Where(expression);
    }

    public async Task<IEnumerable<Estado>> GetAllAsync()
    {
        return await _context.Set<Estado>().ToListAsync();
    }

    public async Task<Estado> GetByIdAsync(string id)
    {
        return await _context.Set<Estado>().FindAsync(id);
    }

    public void Remove(Estado entity)
    {
        _context.Set<Estado>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Estado> entities)
    {
        _context.Set<Estado>().RemoveRange(entities);
    }

    public void Update(Estado entity)
    {
        _context.Set<Estado>().Update(entity);
    }
}

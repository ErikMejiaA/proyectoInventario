
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class RegionRepository : IRegionInterface
{
    //variable context
    protected readonly proyectoInventarioContext _context;
    //constructor
    public RegionRepository(proyectoInventarioContext context)
    {
        _context = context;
    }

    public void Add(Region entity)
    {
        _context.Set<Region>().Add(entity);
    }

    public void AddRange(IEnumerable<Region> entities)
    {
        _context.Set<Region>().AddRange(entities);
    }

    public IEnumerable<Region> Find(Expression<Func<Region, bool>> expression)
    {
        return _context.Set<Region>().Where(expression);
    }

    public async Task<IEnumerable<Region>> GetAllAsync()
    {
        return await _context.Set<Region>().ToListAsync();
    }

    public async Task<Region> GetByIdAsync(string id)
    {
        return await _context.Set<Region>().FindAsync(id);
    }

    public void Remove(Region entity)
    {
        _context.Set<Region>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Region> entities)
    {
        _context.Set<Region>().RemoveRange(entities);
    }

    public void Update(Region entity)
    {
        _context.Set<Region>().Update(entity);
    }
}

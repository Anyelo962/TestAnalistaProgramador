using ImpuestosInternos.WebApi.Core.Entities;
using ImpuestosInternos.WebApi.Core.Interfaces;
using ImpuestosInternos.WebApi.Core.Pagination;
using ImpuestosInternos.WebApi.Infrastructure.InternalRevenueDb;
using Microsoft.EntityFrameworkCore;

namespace ImpuestosInternos.WebApi.Infrastructure.Repository;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{

    private readonly InternalRevenueDbContex _context;
    private DbSet<T> _entities;
    public BaseRepository(InternalRevenueDbContex context)
    {
        _context = context;
        _entities = context.Set<T>();
    }

    public async Task<PagedList<T>> PaginateList(int currentPage, int pageSize)
    {
        var paginateResult = await _entities
            .OrderBy(id => id.Id)
            .Skip((currentPage - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
            
        return PagedList<T>.ToPageList( paginateResult.AsQueryable(), currentPage, pageSize);
    }

    public async Task<List<T>> GetAll()
    {
       return await _entities.ToListAsync();
    }

    public async Task<T?> GetById(int id)
    {
      return await _entities.FindAsync(id);
    }

    public async Task Add(T? entity)
    {
        await _entities.AddAsync(entity);
        await _context.SaveChangesAsync();
    }
    
    public async Task AddRange(IEnumerable<T> entities)
    {
        await _entities.AddRangeAsync(entities);
        await _context.SaveChangesAsync();
    }
    

    public async Task<bool> Update(T entity)
    {
        var updateEntity = await _entities.FindAsync(entity.Id);

        int isUpdate = 0;
        if (updateEntity != null)
        {
            _context.Entry(updateEntity).CurrentValues.SetValues(entity);
             isUpdate = await _context.SaveChangesAsync();
        }

        return isUpdate > 0 ? true : false;
    }

    public async Task<bool> Remove(int id)
    {
        var getEntity = await  _entities.FindAsync(id);

        if (getEntity != null)
        {
            _context.Remove(getEntity);
        }

        var result = await _context.SaveChangesAsync();

       return result > 0 ? true : false;

    }
}
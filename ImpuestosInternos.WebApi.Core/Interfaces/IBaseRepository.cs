using ImpuestosInternos.WebApi.Core.Entities;
using ImpuestosInternos.WebApi.Core.Pagination;

namespace ImpuestosInternos.WebApi.Core.Interfaces;

public interface IBaseRepository<T> where T: BaseEntity
{
    Task<PagedList<T>> PaginateList(int currentPage, int pageSize);
    Task<List<T>> GetAll();
    Task<T?> GetById(int id);
    Task Add(T? entity);
    Task AddRange(IEnumerable<T> entities);
    Task<bool> Update(T entity);
    Task<bool> Remove(int id);
}
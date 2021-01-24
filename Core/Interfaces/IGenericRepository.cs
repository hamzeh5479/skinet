using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Specifications;

namespace Core.Interfaces
{
    public interface IGenericRepository<T>  where T : BaseEntity
    {
        Task<T> GetByIdAsync(int it);   
        Task<IReadOnlyList<T>> ListAllAsync(); 
        Task<T> GetEntityWithSpec(ISpecificaiton<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecificaiton<T> spec);
        Task<int> CountAsync(ISpecificaiton<T> spec);
    }
}
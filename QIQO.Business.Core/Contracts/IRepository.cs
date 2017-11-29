using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QIQO.Pages.Data.Interfaces
{
    public interface IRepository : IDisposable { }

    public interface IRepository<T> : IRepository
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIDAsync(Guid Id);
        Task InsertAsync(T entity);
        Task DeleteAsync(Guid Id);
        void Update(T entity);
        void SaveAsync();
    }

    public interface IReadOnlyRepository<T> : IRepository
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIDAsync(Guid Id);
    }

    public interface IWriteOnlyRepository<T> : IRepository
    {
        Task InsertAsync(T entity);
        Task DeleteAsync(Guid Id);
        void Update(T entity);
        Task SaveAsync();
    }
}
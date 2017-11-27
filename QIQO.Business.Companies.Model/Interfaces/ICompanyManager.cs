using QIQO.Business.Companies.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QIQO.Business.Companies.Model.Interfaces
{
    public interface IManager<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIDAsync(Guid Id);
        Task InsertAsync(T entity);
        Task DeleteAsync(Guid Id);
        Task UpdateAsync(T entity);
    }
    public interface ICompanyManager : IManager<Company> { }
    public interface IAddressManager : IManager<Company> { }
}

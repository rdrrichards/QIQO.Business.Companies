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
        void Update(T entity);
    }
    public interface ICompanyManager : IManager<Company> { }
    public interface IListManager
    {
        Task<IEnumerable<AddressType>> GetAllAddressTypeAsync();
        Task<IEnumerable<AttributeType>> GetAllAttributeTypeAsync();
        Task<IEnumerable<EmployeeType>> GetAllEmployeeTypeAsync();
        Task<IEnumerable<EntityType>> GetAllEntityTypeAsync();
        Task<IEnumerable<ProductType>> GetAllProductTypeAsync();
    }
}

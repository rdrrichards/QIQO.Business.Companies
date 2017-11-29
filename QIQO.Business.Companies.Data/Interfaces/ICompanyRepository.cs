using QIQO.Business.Companies.Data.Entities;
using QIQO.Pages.Data.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QIQO.Business.Companies.Data.Interfaces
{
    public interface ICompanyRepository : IRepository<CompanyData>
    {
    }
    public interface IListRepository : IReadOnlyRepository<AddressTypeData>
    {
        Task<IEnumerable<AddressTypeData>> GetAllAddressTypesAsync();
    }
}

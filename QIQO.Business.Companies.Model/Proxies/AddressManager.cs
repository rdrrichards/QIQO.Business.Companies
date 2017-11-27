using QIQO.Business.Companies.Model.Interfaces;
using System;
using System.Collections.Generic;
using QIQO.Business.Companies.Models;
using System.Threading.Tasks;

namespace QIQO.Business.Companies.Model.Proxies
{
    public class AddressManager : IAddressManager
    {
        public Task DeleteAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Company>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetByIDAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Company entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Company entity)
        {
            throw new NotImplementedException();
        }
    }
}

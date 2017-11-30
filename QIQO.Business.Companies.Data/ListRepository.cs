using QIQO.Business.Companies.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using QIQO.Business.Companies.Data.Entities;
using System.Threading.Tasks;
using QIQO.Business.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using QIQO.Business.Companies.Data.Contexts;

namespace QIQO.Business.Companies.Data
{
    public class ListRepository : RepositoryBase, IListRepository
    {
        private readonly CompanyContext _companyContext;

        public ListRepository(CompanyContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
            _companyContext = context;
        }

        public Task<IEnumerable<AddressTypeData>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AddressTypeData> GetByIDAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AddressTypeData>> GetAllAddressTypesAsync() => await _companyContext.AddressTypes.ToListAsync();

        public async Task<IEnumerable<AttributeTypeData>> GetAllAttributeTypesAsync() => await _companyContext.AttributeTypes.ToListAsync();

        public async Task<IEnumerable<EmployeeTypeData>> GetAllEmployeeTypesAsync() => await _companyContext.EmployeeTypes.ToListAsync();

        public async Task<IEnumerable<EntityTypeData>> GetAllEntityTypesAsync() => await _companyContext.EntityTypes.ToListAsync();

        public async Task<IEnumerable<ProductTypeData>> GetAllProductTypesAsync() => await _companyContext.ProductTypes.ToListAsync();
    }
}

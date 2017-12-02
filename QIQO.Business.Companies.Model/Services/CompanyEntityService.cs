using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Companies.Model.Interfaces;
using QIQO.Business.Companies.Models;
using System;

namespace QIQO.Business.Companies.Model.Services
{
    public class CompanyEntityService : ICompanyEntityService
    {
        private readonly IAddressEntityService _addressEntityService;
        private readonly IEntityAttributeEntityService _entityAttributeEntityService;

        public CompanyEntityService(IAddressEntityService addressEntityService, IEntityAttributeEntityService entityAttributeEntityService)
        {
            _addressEntityService = addressEntityService;
            _entityAttributeEntityService = entityAttributeEntityService;
        }
        public Company Map(CompanyData compData)
        {
            return new Company(compData);
        }

        public CompanyData Map(Company company)
        {
            return new CompanyData()
            {
                CompanyId = company.CompanyId != default(Guid) ? company.CompanyId : Guid.NewGuid(),
                CompanyCode = company.CompanyCode,
                CompanyName = company.CompanyName,
                CompanyDesc = company.CompanyDesc,
                CompanyAddresses = _addressEntityService.Map(company.CompanyAddresses),
                CompanyAttributes = _entityAttributeEntityService.Map(company.CompanyAttributes)
            };
        }
    }

}

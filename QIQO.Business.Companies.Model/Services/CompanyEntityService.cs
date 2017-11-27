using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Companies.Model.Interfaces;
using QIQO.Business.Companies.Models;

namespace QIQO.Business.Companies.Model.Services
{
    public class CompanyEntityService : ICompanyEntityService
    {
        public Company Map(CompanyData compData)
        {
            return new Company(compData);
        }

        public CompanyData Map(Company company)
        {
            return new CompanyData()
            {
                CompanyId = company.CompanyId,
                CompanyCode = company.CompanyCode,
                CompanyName = company.CompanyName,
                CompanyDesc = company.CompanyDesc
            };
        }
    }

}

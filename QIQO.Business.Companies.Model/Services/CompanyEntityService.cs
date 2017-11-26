using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Companies.Model.Interfaces;
using QIQO.Business.Companies.Models;

namespace QIQO.Business.Companies.Model.Services
{
    public class CompanyEntityService : ICompanyEntityService
    {
        public Company Map(CompanyData comp_data)
        {
            return new Company()
            {
                CompanyId = comp_data.CompanyId,
                CompanyCode = comp_data.CompanyCode,
                CompanyName = comp_data.CompanyName,
                CompanyDesc = comp_data.CompanyDesc
            };
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

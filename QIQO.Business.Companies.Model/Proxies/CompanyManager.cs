using QIQO.Business.Companies.Data.Interfaces;
using QIQO.Business.Companies.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using QIQO.Business.Companies.Models;

namespace QIQO.Business.Companies.Model.Proxies
{
    public class CompanyManager : ICompanyManager
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly ICompanyEntityService _companyEntityService;

        public CompanyManager(ICompanyRepository companyRepository, ICompanyEntityService companyEntityService)
        {
            _companyRepository = companyRepository;
            _companyEntityService = companyEntityService;
        }

        public async Task DeleteAsync(Guid Id) => await _companyRepository.DeleteAsync(Id);

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            var company_data = await _companyRepository.GetAllAsync();
            return _companyEntityService.Map(company_data);
        }

        public async Task<Company> GetByIDAsync(Guid Id) => _companyEntityService.Map(await _companyRepository.GetByIDAsync(Id));

        public async Task InsertAsync(Company entity) => await _companyRepository.InsertAsync(_companyEntityService.Map(entity));

        public async Task UpdateAsync(Company entity)
        {
            _companyRepository.Update(_companyEntityService.Map(entity));
            await _companyRepository.SaveAsync();
        }
    }
}

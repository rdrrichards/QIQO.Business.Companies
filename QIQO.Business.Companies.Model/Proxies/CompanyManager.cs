using QIQO.Business.Companies.Data.Interfaces;
using QIQO.Business.Companies.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using QIQO.Business.Companies.Data.Entities;
using System.Threading.Tasks;
using System.Linq;

namespace QIQO.Business.Companies.Model.Proxies
{
    public class CompanyManager : ICompanyManager
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyManager(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task DeleteAsync(Guid Id) => await _companyRepository.DeleteAsync(Id);

        public async Task<IEnumerable<Company>> GetAllAsync() => await _companyRepository.GetAllAsync();

        public async Task<Company> GetByIDAsync(Guid Id) => await _companyRepository.GetByIDAsync(Id);

        public async Task InsertAsync(Company entity) => await _companyRepository.InsertAsync(entity);

        public async Task UpdateAsync(Company entity)
        {
            _companyRepository.Update(entity);
            await _companyRepository.SaveAsync();
        }
    }
}

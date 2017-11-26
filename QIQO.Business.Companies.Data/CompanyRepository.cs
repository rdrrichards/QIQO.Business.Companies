using QIQO.Business.Companies.Data.Interfaces;
using QIQO.Business.Core;
using System;
using System.Collections.Generic;
using QIQO.Business.Companies.Data.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using QIQO.Business.Companies.Data.Contexts;

namespace QIQO.Business.Companies.Data
{
    public class CompanyRepository : RepositoryBase, ICompanyRepository
    {
        private readonly CompanyContext _companyContext;

        public CompanyRepository(CompanyContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
            _companyContext = context;
        }

        public async Task DeleteAsync(Guid Id)
        {
            var product = await _companyContext.Companies.FindAsync(Id);
            _companyContext.Companies.Remove(product);
            await _companyContext.SaveChangesAsync();

        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            return await _companyContext.Companies.ToListAsync();
        }

        public async Task<Company> GetByIDAsync(Guid Id)
        {
            return await _companyContext.Companies.FindAsync(Id);
        }

        public async Task InsertAsync(Company entity)
        {
            entity.AddedDateTime = DateTime.Now;
            entity.AddedUserID = User.Identity.Name;
            entity.UpdateDateTime = DateTime.Now;
            entity.UpdateUserID = User.Identity.Name;
            await _companyContext.Companies.AddAsync(entity);
        }

        public async Task SaveAsync()
        {
            await _companyContext.SaveChangesAsync();
        }

        public void Update(Company entity)
        {
            entity.UpdateDateTime = DateTime.Now;
            entity.UpdateUserID = User.Identity.Name;
            _companyContext.Entry(entity).State = EntityState.Modified;

        }
    }
}

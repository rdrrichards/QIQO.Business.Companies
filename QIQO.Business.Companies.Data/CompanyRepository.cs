using QIQO.Business.Companies.Data.Interfaces;
using QIQO.Business.Core;
using System;
using System.Collections.Generic;
using QIQO.Business.Companies.Data.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using QIQO.Business.Companies.Data.Contexts;
using System.Linq;

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
            var company = await _companyContext.Companies.FindAsync(Id);
            _companyContext.Companies.Remove(company);
            await _companyContext.SaveChangesAsync();

        }

        public async Task<IEnumerable<CompanyData>> GetAllAsync()
        {
            return await _companyContext.Companies.ToListAsync();
        }

        public async Task<CompanyData> GetByIDAsync(Guid Id)
        {
            return await _companyContext.Companies.AsNoTracking()
                .Include(c => c.CompanyAddresses)
                    .ThenInclude(a => a.AddressType)
                .Include(c => c.CompanyAddresses)
                    .ThenInclude(e => e.EntityType)
                .Include(c => c.CompanyAttributes)
                    .ThenInclude(a => a.AttributeType)
                .Include(c => c.CompanyAttributes)
                    .ThenInclude(e => e.EntityType)
                .SingleAsync(c => c.CompanyId == Id);
        }

        public async Task InsertAsync(CompanyData entity)
        {
            entity.AddedDateTime = DateTime.Now;
            entity.AddedUserID = User.Identity.Name;
            entity.UpdateDateTime = DateTime.Now;
            entity.UpdateUserID = User.Identity.Name;
            await _companyContext.Companies.AddAsync(entity);
        }

        public void SaveAsync()
        {
            _companyContext.SaveChanges(true);
        }

        public void Update(CompanyData entity)
        {
            _companyContext.ChangeTracker.TrackGraph(entity, e =>
            {
                if ((e.Entry.Entity as CompanyData) != null)
                {
                    e.Entry.State = EntityState.Modified;
                }
                if ((e.Entry.Entity as EntityTypeData) != null)
                {
                    e.Entry.State = EntityState.Detached;
                }
                if ((e.Entry.Entity as AddressTypeData) != null)
                {
                    e.Entry.State = EntityState.Detached;
                }
                if ((e.Entry.Entity as EntityAttributeData) != null)
                {
                    //_companyContext.Entry(e.Entry.Entity as EntityAttributeData).Property("AttributeValue").IsModified = true;
                }
                if ((e.Entry.Entity as AddressData) != null)
                {
                    var address = e.Entry.Entity as AddressData;
                    _companyContext.Entry(address).Property("AddressLine1").IsModified = true;
                    _companyContext.Entry(address).Property("AddressLine2").IsModified = true;
                    _companyContext.Entry(address).Property("AddressLine3").IsModified = true;
                    _companyContext.Entry(address).Property("AddressLine4").IsModified = true;
                    _companyContext.Entry(address).Property("AddressCity").IsModified = true;
                    _companyContext.Entry(address).Property("AddressState").IsModified = true;
                    _companyContext.Entry(address).Property("AddressCounty").IsModified = true;
                    _companyContext.Entry(address).Property("AddressCountry").IsModified = true;
                    _companyContext.Entry(address).Property("AddressPostalCode").IsModified = true;
                    _companyContext.Entry(address).Property("AddressNotes").IsModified = true;
                    _companyContext.Entry(address).Property("AddressDefaultFlag").IsModified = true;
                    _companyContext.Entry(address).Property("AddressActiveFlag").IsModified = true;
                }
            });
        }
    }
}

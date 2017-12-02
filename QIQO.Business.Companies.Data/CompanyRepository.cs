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
        private const string _user = "Fallback User";
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
                    .ThenInclude(e => e.AddressEntityType)
                .Include(c => c.CompanyAttributes)
                    .ThenInclude(a => a.AttributeType)
                .Include(c => c.CompanyAttributes)
                    .ThenInclude(e => e.AttributeEntityType)
                .SingleAsync(c => c.CompanyId == Id);
        }

        public async Task InsertAsync(CompanyData entity)
        {
            entity.AddedDateTime = DateTime.Now;
            entity.AddedUserID = User.Identity.Name ?? _user;
            entity.UpdateDateTime = DateTime.Now;
            entity.UpdateUserID = User.Identity.Name ?? _user;

            if (entity.CompanyAddresses != null)
                foreach (var address in entity.CompanyAddresses)
                {
                    address.AddedDateTime = DateTime.Now;
                    address.AddedUserID = User.Identity.Name ?? _user;
                    address.UpdateDateTime = DateTime.Now;
                    address.UpdateUserID = User.Identity.Name ?? _user;
                }

            if (entity.CompanyAttributes != null)
                foreach (var attribute in entity.CompanyAttributes)
                {
                    attribute.AddedDateTime = DateTime.Now;
                    attribute.AddedUserID = User.Identity.Name ?? _user;
                    attribute.UpdateDateTime = DateTime.Now;
                    attribute.UpdateUserID = User.Identity.Name ?? _user;
                }

            await _companyContext.Companies.AddAsync(entity);
            try
            {
                await _companyContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

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
                    var company = e.Entry.Entity as CompanyData;
                    _companyContext.Entry(company).Property("AddedUserID").IsModified = false;
                    _companyContext.Entry(company).Property("AddedDateTime").IsModified = false;
                    _companyContext.Entry(company).Property("UpdateDateTime").CurrentValue = DateTime.UtcNow;
                    _companyContext.Entry(company).Property("UpdateUserID").CurrentValue = User.Identity.Name ?? _user;
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
                    var attribute = e.Entry.Entity as EntityAttributeData;
                    _companyContext.Entry(attribute).Property("AddedUserID").IsModified = false;
                    _companyContext.Entry(attribute).Property("AddedDateTime").IsModified = false;
                    _companyContext.Entry(attribute).Property("UpdateDateTime").CurrentValue = DateTime.UtcNow;
                    _companyContext.Entry(attribute).Property("UpdateUserID").CurrentValue = User.Identity.Name ?? _user;
                    _companyContext.Entry(e.Entry.Entity as EntityAttributeData).Property("AttributeValue").IsModified = true;
                }
                if ((e.Entry.Entity as AddressData) != null)
                {
                    var address = e.Entry.Entity as AddressData;
                    //_companyContext.Entry(address).Property("AddressEntityId").IsModified = true;
                    //_companyContext.Entry(address).Property("AddressEntityTypeId").IsModified = true;
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
                    _companyContext.Entry(address).Property("UpdateDateTime").CurrentValue = DateTime.UtcNow;
                    _companyContext.Entry(address).Property("UpdateUserID").CurrentValue = User.Identity.Name ?? _user;
                    _companyContext.Entry(address).Property("AddedUserID").IsModified = false;
                    _companyContext.Entry(address).Property("AddedDateTime").IsModified = false;
                }
            });
        }
    }
}

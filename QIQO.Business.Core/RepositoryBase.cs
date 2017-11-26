using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Principal;

namespace QIQO.Business.Core
{
    public class RepositoryBase
    {
        private bool disposed = false;
        private readonly DbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        protected IPrincipal User => _httpContextAccessor.HttpContext.User;

        public RepositoryBase(DbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                    _context.Dispose();

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
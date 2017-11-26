using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QIQO.Business.Companies.ViewModels;
using QIQO.Business.Core;
using Microsoft.Extensions.Logging;
using QIQO.Business.Companies.Model.Interfaces;
using System;

namespace QIQO.Business.Companies.Controllers
{
    [Produces("application/json")]
    [Route("api/companies")]
    public class CompanyController : QIQOController
    {
        private readonly ICompanyManager _companyManager;

        public CompanyController(ILogger<CompanyController> logger, ICompanyManager companyManager) : base(logger) 
        {
            _companyManager = companyManager;
        }
        // GET api/companies
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return await ExecuteHandledOperationAsync(() =>
            {
                return _companyManager.GetAllAsync();
            });
        }

        // GET api/companies/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            return await ExecuteHandledOperationAsync(() =>
            {
                return _companyManager.GetByIDAsync(id);
            });
        }

        // POST api/companies
        [HttpPost]
        public async Task Post([FromBody]CompanyViewModel value)
        {
            // call something to map the vm to a model, then insert (via model proxy)
            await ExecuteHandledOperationAsync(() =>
            {
                // _companyManager.InsertAsync(value);
            });
        }

        // PUT api/companies/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody]CompanyViewModel value)
        {
            // call something to map the vm to a model, then update (via model proxy)
            await ExecuteHandledOperationAsync(() =>
            {
                // _companyManager.UpdateAsync(value);
            });
        }

        // DELETE api/companies/5
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            // call something to map the vm to a model, then delete (via model proxy)
            await ExecuteHandledOperationAsync(() =>
            {
                _companyManager.DeleteAsync(id);
            });
        }
    }
}

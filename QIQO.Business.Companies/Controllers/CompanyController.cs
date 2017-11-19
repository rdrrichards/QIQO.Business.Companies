using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QIQO.Business.Companies.ViewModels;
using QIQO.Business.Core;
using Microsoft.Extensions.Logging;

namespace QIQO.Business.Companies.Controllers
{
    [Produces("application/json")]
    [Route("api/companies")]
    public class CompanyController : QIQOController
    {
        public CompanyController(ILogger<CompanyController> logger) : base(logger) 
        {
        }
        // GET api/companies
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return await ExecuteHandledOperationAsync(() =>
            {
                return new List<CompanyViewModel>
                {
                    new CompanyViewModel { CompanyName = "Company 1"},
                    new CompanyViewModel { CompanyName = "Company 2"}
                };
            });
        }

        // GET api/companies/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            return await ExecuteHandledOperationAsync(() =>
            {
                return new CompanyViewModel { CompanyName = "Company 1" };
            });
        }

        // POST api/companies
        [HttpPost]
        public async Task Post([FromBody]CompanyViewModel value)
        {
            // call something to map the vm to a model, then insert (via model proxy)
            await ExecuteHandledOperationAsync(() =>
            {

            });
        }

        // PUT api/companies/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody]CompanyViewModel value)
        {
            // call something to map the vm to a model, then update (via model proxy)
            await ExecuteHandledOperationAsync(() =>
            {

            });
        }

        // DELETE api/companies/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            // call something to map the vm to a model, then delete (via model proxy)
            await ExecuteHandledOperationAsync(() =>
            {

            });
        }
    }
}

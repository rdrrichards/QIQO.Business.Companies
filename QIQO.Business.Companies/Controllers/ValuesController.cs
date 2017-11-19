using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QIQO.Business.Companies.ViewModels;

namespace QIQO.Business.Companies.Controllers
{
    [Produces("application/json")]
    [Route("api/companies")]
    public class CompanyController : Controller
    {
        // GET api/companies
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await Task.Run(() =>
            {
                return new List<CompanyViewModel>
                {
                    new CompanyViewModel { CompanyName = "Company 1"},
                    new CompanyViewModel { CompanyName = "Company 2"}
                };
            }));
        }

        // GET api/companies/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            return Ok(await Task.Run(() =>
            {
                return new CompanyViewModel { CompanyName = "Company 1" };
            }));
        }

        // POST api/companies
        [HttpPost]
        public void Post([FromBody]CompanyViewModel value)
        {
        }

        // PUT api/companies/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]CompanyViewModel value)
        {
        }

        // DELETE api/companies/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

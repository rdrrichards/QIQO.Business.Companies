using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QIQO.Business.Companies.ViewModels;
using QIQO.Business.Core;
using Microsoft.Extensions.Logging;
using QIQO.Business.Companies.Model.Interfaces;
using System.Collections.Generic;

namespace QIQO.Business.Companies.Controllers
{
    [Produces("application/json")]
    [Route("api/lists")]
    public class ListController : QIQOController
    {
        private readonly IListManager _listManager;

        public ListController(ILogger<ListController> logger, IListManager listManager) : base(logger) 
        {
            _listManager = listManager;
        }
        // GET api/companies
        [HttpGet("addresstypes")]
        public async Task<IActionResult> GetAddressTypesAsync()
        {
            return await ExecuteHandledOperationAsync(async () =>
            {
                var ret = new List<AddressTypeViewModel>();
                var addresses = await _listManager.GetAllAddressTypeAsync();
                foreach (var address in addresses)
                    ret.Add(new AddressTypeViewModel(address));

                return ret;
            });
        }
        // GET api/companies
        [HttpGet("attributetypes")]
        public async Task<IActionResult> GetAttributeTypesAsync()
        {
            return await ExecuteHandledOperationAsync(async () =>
            {
                var ret = new List<AttributeTypeViewModel>();
                var attributes = await _listManager.GetAllAttributeTypeAsync();
                foreach (var attribute in attributes)
                    ret.Add(new AttributeTypeViewModel(attribute));

                return ret;
            });
        }
        // GET api/companies
        [HttpGet("employeetypes")]
        public async Task<IActionResult> GetEmployeeTypesAsync()
        {
            return await ExecuteHandledOperationAsync(async () =>
            {
                var ret = new List<EmployeeTypeViewModel>();
                var employees = await _listManager.GetAllEmployeeTypeAsync();
                foreach (var employee in employees)
                    ret.Add(new EmployeeTypeViewModel(employee));

                return ret;
            });
        }
        // GET api/companies
        [HttpGet("entitytypes")]
        public async Task<IActionResult> GetEntityTypesAsync()
        {
            return await ExecuteHandledOperationAsync(async () =>
            {
                var ret = new List<EntityTypeViewModel>();
                var entities = await _listManager.GetAllEntityTypeAsync();
                foreach (var entity in entities)
                    ret.Add(new EntityTypeViewModel(entity));

                return ret;
            });
        }
        // GET api/companies
        [HttpGet("producttypes")]
        public async Task<IActionResult> GetProductTypesAsync()
        {
            return await ExecuteHandledOperationAsync(async () =>
            {
                var ret = new List<ProductTypeViewModel>();
                var products = await _listManager.GetAllProductTypeAsync();
                foreach (var product in products)
                    ret.Add(new ProductTypeViewModel(product));

                return ret;
            });
        }
    }
}

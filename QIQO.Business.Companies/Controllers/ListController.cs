using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QIQO.Business.Companies.ViewModels;
using QIQO.Business.Core;
using Microsoft.Extensions.Logging;
using QIQO.Business.Companies.Model.Interfaces;
using System;
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
    }
}

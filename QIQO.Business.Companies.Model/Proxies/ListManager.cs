using QIQO.Business.Companies.Data.Interfaces;
using QIQO.Business.Companies.Model.Interfaces;
using QIQO.Business.Companies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QIQO.Business.Companies.Model.Proxies
{
    public class ListManager : IListManager
    {
        private readonly IListRepository _listRepository;
        private readonly IAddressTypeEntityService _addressTypeEntityService;

        public ListManager(IListRepository listRepository, IAddressTypeEntityService addressTypeEntityService)
        {
            _listRepository = listRepository;
            _addressTypeEntityService = addressTypeEntityService;
        }

        public async Task<IEnumerable<AddressType>> GetAllAddressTypeAsync() => _addressTypeEntityService.Map(await _listRepository.GetAllAddressTypesAsync());
    }
}

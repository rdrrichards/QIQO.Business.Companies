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
        private readonly IAttributeTypeEntityService _attributeTypeEntityService;
        private readonly IEmployeeTypeEntityService _employeeTypeEntityService;
        private readonly IEntityTypeEntityService _entityTypeEntityService;
        private readonly IProductTypeEntityService _productTypeEntityService;

        public ListManager(IListRepository listRepository, IAddressTypeEntityService addressTypeEntityService, 
            IAttributeTypeEntityService attributeTypeEntityService, IEmployeeTypeEntityService employeeTypeEntityService, 
            IEntityTypeEntityService entityTypeEntityService, IProductTypeEntityService productTypeEntityService)
        {
            _listRepository = listRepository;
            _addressTypeEntityService = addressTypeEntityService;
            _attributeTypeEntityService = attributeTypeEntityService;
            _employeeTypeEntityService = employeeTypeEntityService;
            _entityTypeEntityService = entityTypeEntityService;
            _productTypeEntityService = productTypeEntityService;
        }

        public async Task<IEnumerable<AddressType>> GetAllAddressTypeAsync() => _addressTypeEntityService.Map(await _listRepository.GetAllAddressTypesAsync());

        public async Task<IEnumerable<AttributeType>> GetAllAttributeTypeAsync() => _attributeTypeEntityService.Map(await _listRepository.GetAllAttributeTypesAsync());

        public async Task<IEnumerable<EmployeeType>> GetAllEmployeeTypeAsync() => _employeeTypeEntityService.Map(await _listRepository.GetAllEmployeeTypesAsync());

        public async Task<IEnumerable<EntityType>> GetAllEntityTypeAsync() => _entityTypeEntityService.Map(await _listRepository.GetAllEntityTypesAsync());

        public async Task<IEnumerable<ProductType>> GetAllProductTypeAsync() => _productTypeEntityService.Map(await _listRepository.GetAllProductTypesAsync());
    }
}

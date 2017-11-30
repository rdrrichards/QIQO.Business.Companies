using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Companies.Model.Interfaces;
using QIQO.Business.Companies.Models;

namespace QIQO.Business.Companies.Model.Services
{
    public class AddressEntityService : IAddressEntityService
    {
        private readonly IAddressTypeEntityService _addressTypeEntityService;
        private readonly IEntityTypeEntityService _entityTypeEntityService;

        public AddressEntityService(IAddressTypeEntityService addressTypeEntityService, IEntityTypeEntityService entityTypeEntityService)
        {
            _addressTypeEntityService = addressTypeEntityService;
            _entityTypeEntityService = entityTypeEntityService;
        }
        public Address Map(AddressData ent)
        {
            return new Address(ent);
        }

        public AddressData Map(Address ent)
        {
            return new AddressData
            {
                AddressId = ent.AddressId,
                AddressLine1 = ent.AddressLine1,
                AddressLine2 = ent.AddressLine2,
                AddressLine3 = ent.AddressLine3,
                AddressLine4 = ent.AddressLine4,
                AddressCity = ent.AddressCity,
                AddressState = ent.AddressState,
                AddressPostalCode = ent.AddressPostalCode,
                AddressActiveFlag = ent.AddressActiveFlag,
                AddressCounty = ent.AddressCounty,
                AddressCountry = ent.AddressCountry,
                AddressDefaultFlag = ent.AddressDefaultFlag,
                AddressNotes = ent.AddressNotes,
                AddressType = _addressTypeEntityService.Map(ent.AddressType),
                AddressEntityId = ent.EntityId,
                AddressEntityType = _entityTypeEntityService.Map(ent.EntityType)
            };
        }
    }
}

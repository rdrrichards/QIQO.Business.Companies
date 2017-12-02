using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Companies.Model.Interfaces;
using QIQO.Business.Companies.Models;
using System;

namespace QIQO.Business.Companies.Model.Services
{
    public class AddressEntityService : IAddressEntityService
    {
        public Address Map(AddressData ent)
        {
            return new Address(ent);
        }

        public AddressData Map(Address ent)
        {
            return new AddressData
            {
                AddressId = ent.AddressId != default(Guid) ? ent.AddressId : Guid.NewGuid(),
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
                AddressTypeId = ent.AddressTypeId,
                AddressEntityId = ent.EntityId,
                AddressEntityTypeId = ent.EntityTypeId
            };
        }
    }
}

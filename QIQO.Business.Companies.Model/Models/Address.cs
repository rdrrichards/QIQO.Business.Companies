
using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Core.Contracts;
using System;

namespace QIQO.Business.Companies.Models
{
    public class Address : IModel
    {
        public Address(AddressData addressData)
        {
            if (addressData == null) throw new ArgumentNullException(nameof(addressData));
            AddressId = addressData.AddressId;
            AddressLine1 = addressData.AddressLine1;
            AddressLine2 = addressData.AddressLine2;
            AddressLine3 = addressData.AddressLine3;
            AddressLine4 = addressData.AddressLine4;
            AddressCity = addressData.AddressCity;
            AddressState = addressData.AddressState;
            AddressPostalCode = addressData.AddressPostalCode;
            AddressActiveFlag = addressData.AddressActiveFlag;
            AddressCounty = addressData.AddressCounty;
            AddressCountry = addressData.AddressCountry;
            AddressDefaultFlag = addressData.AddressDefaultFlag;
            AddressNotes = addressData.AddressNotes;
            EntityId = addressData.AddressEntityId;
            SetAddressType(addressData.AddressType);
            SetEntityType(addressData.AddressEntityType);
        }
        public Address(Address address)
        {
            if (address == null) throw new ArgumentNullException(nameof(address));
            AddressId = address.AddressId;
            AddressLine1 = address.AddressLine1;
            AddressLine2 = address.AddressLine2;
            AddressLine3 = address.AddressLine3;
            AddressLine4 = address.AddressLine4;
            AddressCity = address.AddressCity;
            AddressState = address.AddressState;
            AddressPostalCode = address.AddressPostalCode;
            AddressActiveFlag = address.AddressActiveFlag;
            AddressCounty = address.AddressCounty;
            AddressCountry = address.AddressCountry;
            AddressDefaultFlag = address.AddressDefaultFlag;
            AddressNotes = address.AddressNotes;
            EntityId = address.EntityId;
            SetAddressType(address.AddressType);
            SetEntityType(address.EntityType);
        }
        public Address(Guid addressId, string addressLine1, string addressLine2, string addressLine3, string addressLine4, string addressCity,
            string addressState, string addressPostalCode, string addressCounty, string addressCountry, bool addressActiveFlag, bool addressDefaultFlag,
            string addressNotes, Guid entityId, AddressType addressType, EntityType entityType)
        {
            AddressId = addressId;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            AddressLine4 = addressLine4;
            AddressCity = addressCity;
            AddressState = addressState;
            AddressPostalCode = addressPostalCode;
            AddressActiveFlag = addressActiveFlag;
            AddressCounty = addressCounty;
            AddressCountry = addressCountry;
            AddressDefaultFlag = addressDefaultFlag;
            AddressNotes = addressNotes;
            EntityId = entityId;
            SetAddressType(addressType);
            SetEntityType(entityType);
        }
        public Guid AddressId { get; private set; }
        public AddressType AddressType { get; private set; } = new AddressType(new AddressTypeData());
        public Guid EntityId { get; private set; }
        public EntityType EntityType { get; private set; } = new EntityType(new EntityTypeData());
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string AddressLine3 { get; private set; }
        public string AddressLine4 { get; private set; }
        public string AddressCity { get; private set; }
        public string AddressState { get; private set; }
        public string AddressCounty { get; private set; }
        public string AddressCountry { get; private set; }
        public string AddressPostalCode { get; private set; }
        public string AddressNotes { get; private set; }
        public bool AddressDefaultFlag { get; private set; } = true;
        public bool AddressActiveFlag { get; private set; } = true;

        public void SetAddressType(AddressType addressType)
        {
            AddressType = new AddressType(addressType);
        }

        public void SetAddressType(AddressTypeData addressTypeData)
        {
            AddressType = new AddressType(addressTypeData);
        }

        public void SetEntityType(EntityType entityType)
        {
            EntityType = new EntityType(entityType);
        }

        public void SetEntityType(EntityTypeData entityTypeData)
        {
            EntityType = new EntityType(entityTypeData);
        }
    }
}

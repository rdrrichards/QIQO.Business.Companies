using QIQO.Business.Companies.Models;
using System;

namespace QIQO.Business.Companies.ViewModels
{
    public class AddressViewModel
    {
        public AddressViewModel() { }
        public AddressViewModel(Address address)
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
        public Guid AddressId { get; set; }
        public AddressTypeViewModel AddressType { get; set; } = new AddressTypeViewModel();
        public Guid EntityId { get; set; }
        public EntityTypeViewModel EntityType { get; set; } = new EntityTypeViewModel();
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressCounty { get; set; }
        public string AddressCountry { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressNotes { get; set; }
        public bool AddressDefaultFlag { get; set; } = true;
        public bool AddressActiveFlag { get; set; } = true;

        public void SetAddressType(AddressType addressType)
        {
            AddressType = new AddressTypeViewModel(addressType);
        }

        public void SetEntityType(EntityType entityType)
        {
            EntityType = new EntityTypeViewModel(entityType);
        }
    }
}

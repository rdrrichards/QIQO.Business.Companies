using QIQO.Business.Companies.Models;
using System;

namespace QIQO.Business.Companies.ViewModels
{
    public class AddressTypeViewModel
    {
        public AddressTypeViewModel() { }
        public AddressTypeViewModel(AddressType addressType)
        {
            if (addressType == null) throw new ArgumentNullException(nameof(addressType));
            AddressTypeId = addressType.AddressTypeId;
            AddressTypeCode = addressType.AddressTypeCode;
            AddressTypeName = addressType.AddressTypeName;
            AddressTypeCategory = addressType.AddressTypeCategory;
            AddressTypeDesc = addressType.AddressTypeDesc;
        }
        public Guid AddressTypeId { get; set; }
        public string AddressTypeCode { get; set; }
        public string AddressTypeCategory { get; set; }
        public string AddressTypeName { get; set; }
        public string AddressTypeDesc { get; set; }
    }
}

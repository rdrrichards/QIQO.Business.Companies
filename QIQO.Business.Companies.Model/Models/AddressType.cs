using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Core.Contracts;
using System;

namespace QIQO.Business.Companies.Models
{
    public class AddressType : IModel
    {
        public AddressType(AddressTypeData addressTypeData)
        {
            if (addressTypeData == null) throw new ArgumentNullException(nameof(addressTypeData));
            AddressTypeId = addressTypeData.AddressTypeId;
            AddressTypeCode = addressTypeData.AddressTypeCode;
            AddressTypeName = addressTypeData.AddressTypeName;
            AddressTypeCategory = addressTypeData.AddressTypeCategory;
            AddressTypeDesc = addressTypeData.AddressTypeDesc;
        }
        public AddressType(AddressType addressType)
        {
            if (addressType == null) throw new ArgumentNullException(nameof(addressType));
            AddressTypeId = addressType.AddressTypeId;
            AddressTypeCode = addressType.AddressTypeCode;
            AddressTypeName = addressType.AddressTypeName;
            AddressTypeCategory = addressType.AddressTypeCategory;
            AddressTypeDesc = addressType.AddressTypeDesc;
        }
        public Guid AddressTypeId { get; private set; }
        public string AddressTypeCode { get; private set; }
        public string AddressTypeCategory { get; private set; }
        public string AddressTypeName { get; private set; }
        public string AddressTypeDesc { get; private set; }
    }

}

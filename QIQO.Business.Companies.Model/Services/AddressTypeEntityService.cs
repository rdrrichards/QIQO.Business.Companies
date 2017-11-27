using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Companies.Model.Interfaces;
using QIQO.Business.Companies.Models;

namespace QIQO.Business.Companies.Model.Services
{
    public class AddressTypeEntityService : IAddressTypeEntityService
    {
        public AddressType Map(AddressTypeData ent)
        {
            return new AddressType(ent);
        }

        public AddressTypeData Map(AddressType ent)
        {
            return new AddressTypeData
            {
                AddressTypeId = ent.AddressTypeId,
                AddressTypeCode = ent.AddressTypeCode,
                AddressTypeName = ent.AddressTypeName,
                AddressTypeDesc = ent.AddressTypeDesc,
                AddressTypeCategory = ent.AddressTypeCategory
            };
        }
    }
}

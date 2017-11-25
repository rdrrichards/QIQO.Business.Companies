using System;

namespace QIQO.Business.Companies.Models
{
    public class AddressType
    {
        public Guid AddressTypeId { get; set; }
        public string AddressTypeCode { get; set; }
        public string AddressTypeCategory { get; set; }
        public string AddressTypeName { get; set; }
        public string AddressTypeDesc { get; set; }
    }

}

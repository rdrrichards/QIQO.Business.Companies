using System;

namespace QIQO.Business.Companies.Models
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public AddressType AddressType { get; set; }
        public Guid EntityId { get; set; }
        public EntityType EntityType { get; set; }
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
    }
}

using System;

namespace QIQO.Business.Companies.Models
{
    public class EntityType
    {
        public Guid EntityTypeId { get; set; }
        public string EntityTypeCode { get; set; }
        public string EntityTypeCategory { get; set; }
        public string EntityTypeName { get; set; }
        public string EntityTypeDesc { get; set; }
    }
}

using QIQO.Business.Core.Contracts;
using System;

namespace QIQO.Business.Companies.Models
{
    public class EntityType : IModel
    {
        public Guid EntityTypeId { get; set; }
        public string EntityTypeCode { get; set; }
        public string EntityTypeCategory { get; set; }
        public string EntityTypeName { get; set; }
        public string EntityTypeDesc { get; set; }
    }
}

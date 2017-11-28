using QIQO.Business.Companies.Models;
using System;

namespace QIQO.Business.Companies.ViewModels
{
    public class EntityTypeViewModel
    {
        public EntityTypeViewModel() { }
        public EntityTypeViewModel(EntityType entityType)
        {
            if (entityType == null) throw new ArgumentNullException(nameof(entityType));
            EntityTypeId = entityType.EntityTypeId;
            EntityTypeCode = entityType.EntityTypeCode;
            EntityTypeName = entityType.EntityTypeName;
            EntityTypeDesc = entityType.EntityTypeDesc;
            EntityTypeCategory = entityType.EntityTypeCategory;
        }

        public Guid EntityTypeId { get; set; }
        public string EntityTypeCode { get; set; }
        public string EntityTypeCategory { get; set; }
        public string EntityTypeName { get; set; }
        public string EntityTypeDesc { get; set; }
    }
}

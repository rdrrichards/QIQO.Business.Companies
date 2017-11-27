using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Companies.Model.Interfaces;
using QIQO.Business.Companies.Models;

namespace QIQO.Business.Companies.Model.Services
{
    public class EntityTypeEntityService : IEntityTypeEntityService
    {
        public EntityType Map(EntityTypeData ent)
        {
            return new EntityType(ent);
        }

        public EntityTypeData Map(EntityType ent)
        {
            return new EntityTypeData
            {
                EntityTypeId = ent.EntityTypeId,
                EntityTypeCode = ent.EntityTypeCode,
                EntityTypeName = ent.EntityTypeName,
                EntityTypeDesc = ent.EntityTypeDesc,
                EntityTypeCategory = ent.EntityTypeCategory
            };
        }
    }
}

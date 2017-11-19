using System.Collections.Generic;

namespace QIQO.Business.Companies.Data.Entities
{
    public class Product
    {
        public int ProductKey { get; set; }
        public QIQOProductType ProductType { get; set; } = QIQOProductType.Sweet9;
        public ProductType ProductTypeData { get; set; } = new ProductType();
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public string ProductNameShort { get; set; }
        public string ProductNameLong { get; set; }
        public string ProductImagePath { get; set; }
        public ICollection<EntityAttribute> ProductAttributes { get; set; } = new List<EntityAttribute>();
        public string ProductDescCombo { get; set; }

    }

}

using System.ComponentModel.DataAnnotations;

namespace QIQO.Business.Companies.Data.Entities
{
    public class ProductType
    {
        [Key]
        public int ProductTypeKey { get; set; }

        public string ProductTypeCategory { get; set; }
        public string ProductTypeCode { get; set; }
        public string ProductTypeName { get; set; }
        public string ProductTypeDesc { get; set; }
    }

}

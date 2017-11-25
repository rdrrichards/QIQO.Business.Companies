using System;

namespace QIQO.Business.Companies.Models
{
    public class ProductType
    {
        public Guid ProductTypeId { get; set; }
        public string ProductTypeCode { get; set; }
        public string ProductTypeCategory { get; set; }
        public string ProductTypeName { get; set; }
        public string ProductTypeDesc { get; set; }
    }
}

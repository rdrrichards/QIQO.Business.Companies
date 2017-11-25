using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        public ProductType ProductType { get; set; }
        [Required(ErrorMessage = "A product code must be provided")]
        [MaxLength(20, ErrorMessage ="A product code cannot be more than 20 characters long")]
        [Display(Name = "Product Code")]
        public string ProductCode { get; set; }
        [Required(ErrorMessage = "A product name must be provided")]
        [MaxLength(150, ErrorMessage = "A product name cannot be more than 150 characters long")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "A product description must be provided")]
        [MaxLength(1024, ErrorMessage = "A product description cannot be more than 1024 characters long")]
        [Display(Name = "Product Description")]
        public string ProductDesc { get; set; }
        [MaxLength(50, ErrorMessage = "A product short name cannot be more than 50 characters long")]
        [Display(Name = "Product Short Name")]
        public string ProductNameShort { get; set; }
        [MaxLength(512, ErrorMessage = "A product long name cannot be more than 512 characters long")]
        [Display(Name = "Product Long Name")]
        public string ProductNameLong { get; set; }
        [MaxLength(255, ErrorMessage = "A product image path cannot be more than 255 characters long")]
        [Display(Name = "Product Image Path")]
        public string ProductImagePath { get; set; }
        [ForeignKey("EntityKey")]
        public ICollection<EntityAttribute> ProductAttributes { get; set; }

    }

}

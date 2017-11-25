using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
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
        [Required(ErrorMessage = "A product must have a base price")]
        public decimal ProductBasePrice { get; set; }
        [Required(ErrorMessage = "A product must have a cost associated with it")]
        public decimal ProductCost { get; set; }
        [Required(ErrorMessage = "A product must have a defauolt quantity")]
        public int ProductDefaultQuantity { get; set; }
        [MaxLength(20, ErrorMessage = "The product income account cannot be longer than 20 characters")]
        public string ProductIncomeAccount { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(30, ErrorMessage = "The added user id cannot be longer than 30 characters")]
        [Required]
        public string AddedUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime AddedDateTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(30, ErrorMessage = "The updated user id cannot be longer than 30 characters")]
        [Required]
        public string UpdateUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDateTime { get; set; }
    }
}

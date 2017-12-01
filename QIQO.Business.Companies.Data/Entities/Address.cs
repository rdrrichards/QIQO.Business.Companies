using QIQO.Business.Core.Contracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class AddressData : IEntity
    {
        [Key]
        public Guid AddressId { get; set; }
        public AddressTypeData AddressType { get; set; }
        [Required]
        public Guid AddressTypeId { get; set; }
        [Required]
        public Guid AddressEntityId { get; set; }
        [Required]
        [ForeignKey("AddressEntityTypeId")]
        public EntityTypeData AddressEntityType { get; set; }
        [Required]
        public Guid AddressEntityTypeId { get; set; }
        [MaxLength(100, ErrorMessage = "The address line cannot be longer than 100 characters")]
        [Required]
        public string AddressLine1 { get; set; }
        [MaxLength(100, ErrorMessage = "The address line cannot be longer than 100 characters")]
        public string AddressLine2 { get; set; }
        [MaxLength(100, ErrorMessage = "The address line cannot be longer than 100 characters")]
        public string AddressLine3 { get; set; }
        [MaxLength(100, ErrorMessage = "The address line cannot be longer than 100 characters")]
        public string AddressLine4 { get; set; }
        [MaxLength(100, ErrorMessage = "The address city cannot be longer than 100 characters")]
        [Required]
        public string AddressCity { get; set; }
        [MaxLength(10, ErrorMessage = "The address state cannot be longer than 10 characters")]
        [Required]
        public string AddressState { get; set; }
        [MaxLength(50, ErrorMessage = "The address county cannot be longer than 50 characters")]
        public string AddressCounty { get; set; }
        [MaxLength(50, ErrorMessage = "The address country cannot be longer than 50 characters")]
        public string AddressCountry { get; set; }
        [MaxLength(10, ErrorMessage = "The address postal code cannot be longer than 10 characters")]
        [Required]
        public string AddressPostalCode { get; set; }
        [MaxLength(100, ErrorMessage = "The address note cannot be longer than 100 characters")]
        public string AddressNotes { get; set; }
        public bool AddressDefaultFlag { get; set; }
        public bool AddressActiveFlag { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(30, ErrorMessage = "The added user id cannot be longer than 30 characters")]
        [Required]
        public string AddedUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime AddedDateTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(30, ErrorMessage = "The updated user id cannot be longer than 30 characters")]
        [Required]
        public string UpdateUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime UpdateDateTime { get; set; }

    }

}

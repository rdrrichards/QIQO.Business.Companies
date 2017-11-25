using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class Address
    {
        [Key]
        public Guid AddressId { get; set; }
        public AddressType AddressType { get; set; }
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        [MaxLength(100, ErrorMessage = "The address line cannot be longer than 100 characters")]
        public string AddressLine1 { get; set; }
        [MaxLength(100, ErrorMessage = "The address line cannot be longer than 100 characters")]
        public string AddressLine2 { get; set; }
        [MaxLength(100, ErrorMessage = "The address line cannot be longer than 100 characters")]
        public string AddressLine3 { get; set; }
        [MaxLength(100, ErrorMessage = "The address line cannot be longer than 100 characters")]
        public string AddressLine4 { get; set; }
        [MaxLength(100, ErrorMessage = "The address city cannot be longer than 100 characters")]
        public string AddressCity { get; set; }
        [MaxLength(10, ErrorMessage = "The address state cannot be longer than 10 characters")]
        public string AddressState { get; set; }
        [MaxLength(50, ErrorMessage = "The address county cannot be longer than 50 characters")]
        public string AddressCounty { get; set; }
        [MaxLength(50, ErrorMessage = "The address country cannot be longer than 50 characters")]
        public string AddressCountry { get; set; }
        [MaxLength(10, ErrorMessage = "The address postal code cannot be longer than 10 characters")]
        public string AddressPostalCode { get; set; }
        [MaxLength(100, ErrorMessage = "The address note cannot be longer than 100 characters")]
        public string AddressNotes { get; set; }
        public bool AddressDefaultFlag { get; set; }
        public bool AddressActiveFlag { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(30, ErrorMessage = "The added user id cannot be longer than 30 characters")]
        public string AddedUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime AddedDateTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(30, ErrorMessage = "The updated user id cannot be longer than 30 characters")]
        public string UpdateUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDateTime { get; set; }

    }

}

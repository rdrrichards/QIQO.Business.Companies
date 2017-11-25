using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class FeeSchedule
    {
        [Key]
        public Guid FeeScheduleId { get; set; }
        public Guid CompanyId { get; set; }
        [Required]
        public DateTime FeeScheduleStartDate { get; set; }
        public DateTime FeeScheduleEndDate { get; set; }
        [MaxLength(20, ErrorMessage = "The fee schedule type code cannot be longer than 20 characters")]
        [Required]
        public string FeeScheduleTypeCode { get; set; }
        [Required]
        public decimal FeeScheduleValue { get; set; }
        [MaxLength(150, ErrorMessage = "A product description cannot be more than 150 characters long")]
        public string ProductDesc { get; set; }
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
        public Product Product { get; set; }
    }

}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class FeeSchedule
    {
        [Key]
        public Guid FeeScheduleId { get; set; }
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        public Guid ProductId { get; set; }
        public DateTime FeeScheduleStartDate { get; set; }
        public DateTime FeeScheduleEndDate { get; set; }
        [MaxLength(20, ErrorMessage = "The fee schedule type code cannot be longer than 20 characters")]
        public string FeeScheduleTypeCode { get; set; }
        public decimal FeeScheduleValue { get; set; }
        public string ProductDesc { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string AddedUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime AddedDateTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string UpdateUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDateTime { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; } = new Product();
    }

}

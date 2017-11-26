using QIQO.Business.Core.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class CompanyData : IEntity
    {
        [Key]
        public Guid CompanyId { get; set; }
        [MaxLength(20, ErrorMessage = "The company code cannot be longer than 20 characters")]
        [Required]
        public string CompanyCode { get; set; }
        [MaxLength(100, ErrorMessage = "The company name cannot be longer than 100 characters")]
        [Required]
        public string CompanyName { get; set; }
        [MaxLength(255, ErrorMessage = "The company description cannot be longer than 255 characters")]
        [Required]
        public string CompanyDesc { get; set; }
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
        public ICollection<EmployeeData> Employees { get; set; }
        public ICollection<ChartOfAccountData> GLAccounts { get; set; }
        public ICollection<FeeScheduleData> FeeSchedules { get; set; }
        public ICollection<LedgerData> Ledgers { get; set; }
        [ForeignKey("EntityId")]
        public ICollection<EntityAttributeData> CompanyAttributes { get; set; }
        [ForeignKey("EntityId")]
        public ICollection<AddressData> CompanyAddresses { get; set; }
        public ICollection<ProductData> Products { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class ChartOfAccount
    {
        [Key]
        public Guid ChartOfAccountId { get; set; }
        [MaxLength(20, ErrorMessage = "The account number cannot be longer than 20 characters")]
        [Required]
        public string AccountNo { get; set; }
        [MaxLength(10, ErrorMessage = "The account type cannot be longer than 10 characters")]
        [Required]
        public string AccountType { get; set; }
        [MaxLength(50, ErrorMessage = "The account name cannot be longer than 50 characters")]
        [Required]
        public string AccountName { get; set; }
        [MaxLength(20, ErrorMessage = "The account balance type cannot be longer than 20 characters")]
        [Required]
        public string BalanceType { get; set; }
        public bool BankAccountFlag { get; set; }
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
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

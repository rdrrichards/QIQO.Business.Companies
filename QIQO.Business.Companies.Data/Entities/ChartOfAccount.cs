using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class ChartOfAccount
    {
        [Key]
        public Guid ChartOfAccountId { get; set; }
        public string AccountNo { get; set; }
        public string AccountType { get; set; }
        public string AccountName { get; set; }
        public string BalanceType { get; set; }
        public string BankAccountFlag { get; set; }
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string AddedUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime AddedDateTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string UpdateUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDateTime { get; set; }

    }
}

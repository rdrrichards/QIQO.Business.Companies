using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QIQO.Business.Companies.Data.Entities
{
    public class Ledger
    {
        [Key]
        public Guid LedgerId { get; set; }
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        public string LedgeCode { get; set; }
        public string LedgeName { get; set; }
        public string LedgeDesc { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string AddedUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime AddedDateTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string UpdateUserID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDateTime { get; set; }
        public ICollection<LedgerTxn> LedgerTxns { get; set; }

    }

}

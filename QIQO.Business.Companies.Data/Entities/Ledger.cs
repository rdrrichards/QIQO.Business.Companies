using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QIQO.Business.Companies.Data.Entities
{
    public class Ledger
    {
        [Key]
        public int LedgerKey { get; set; }
        public int CompanyKey { get; set; }
        public string LedgeCode { get; set; }
        public string LedgeName { get; set; }
        public string LedgeDesc { get; set; }
        public string AddedUserID { get; set; }
        public DateTime AddedDateTime { get; set; }
        public string UpdateUserID { get; set; }
        public DateTime UpdateDateTime { get; set; }

        public ICollection<LedgerTxn> LedgerTxns { get; set; } = new List<LedgerTxn>();

    }

}

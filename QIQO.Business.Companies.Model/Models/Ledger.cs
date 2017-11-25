using System;
using System.Collections.Generic;

namespace QIQO.Business.Companies.Models
{
    public class Ledger
    {
        public Guid LedgerId { get; set; }
        public Guid CompanyId { get; set; }
        public string LedgeCode { get; set; }
        public string LedgeName { get; set; }
        public string LedgeDesc { get; set; }
        public List<LedgerTxn> LedgerTxns { get; set; }
    }
}

using QIQO.Business.Core.Contracts;
using System;

namespace QIQO.Business.Companies.Models
{
    public class LedgerTxn : IModel
    {
        public Guid LedgerTxnId { get; set; }
        public Guid LedgerId { get; set; }
        public string Comment { get; set; }
        public string AccountFrom { get; set; }
        public string AccountTo { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime PostDate { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public int LedgerTxnNum { get; set; }
    }
}

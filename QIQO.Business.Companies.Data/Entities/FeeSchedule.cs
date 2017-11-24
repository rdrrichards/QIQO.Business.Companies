using System;
using System.ComponentModel.DataAnnotations;

namespace QIQO.Business.Companies.Data.Entities
{
    public class FeeSchedule
    {
        [Key]
        public int FeeScheduleKey { get; set; }
        public int CompanyKey { get; set; }
        public int AccountKey { get; set; }
        public int ProductKey { get; set; }
        public DateTime FeeScheduleStartDate { get; set; }
        public DateTime FeeScheduleEndDate { get; set; }
        public string FeeScheduleTypeCode { get; set; }
        public decimal FeeScheduleValue { get; set; }
        public string ProductDesc { get; set; }
        public string ProductCode { get; set; }
        public string AddedUserID { get; set; }
        public DateTime AddedDateTime { get; set; }
        public string UpdateUserID { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public string AccountName { get; set; }
        public string AccountCode { get; set; }
        public Product Product { get; set; } = new Product();
    }

}

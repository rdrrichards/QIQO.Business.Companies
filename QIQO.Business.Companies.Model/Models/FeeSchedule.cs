using QIQO.Business.Core.Contracts;
using System;

namespace QIQO.Business.Companies.Models
{
    public class FeeSchedule : IModel
    {
        public Guid FeeScheduleId { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime FeeScheduleStartDate { get; set; }
        public DateTime FeeScheduleEndDate { get; set; }
        public string FeeScheduleTypeCode { get; set; }
        public decimal FeeScheduleValue { get; set; }
        public string ProductDesc { get; set; }
        public Product Product { get; set; }
    }
}

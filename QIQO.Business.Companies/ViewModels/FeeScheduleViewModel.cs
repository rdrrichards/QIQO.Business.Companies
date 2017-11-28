using QIQO.Business.Companies.Models;
using System;

namespace QIQO.Business.Companies.ViewModels
{
    public class FeeScheduleViewModel
    {
        public FeeScheduleViewModel() { }
        public FeeScheduleViewModel(FeeSchedule feeSchedule)
        {
            if (feeSchedule == null) throw new ArgumentNullException(nameof(feeSchedule));
            FeeScheduleId = feeSchedule.FeeScheduleId;
            CompanyId = feeSchedule.CompanyId;
            FeeScheduleStartDate = feeSchedule.FeeScheduleStartDate;
            FeeScheduleEndDate = feeSchedule.FeeScheduleEndDate;
            FeeScheduleTypeCode = feeSchedule.FeeScheduleTypeCode;
            FeeScheduleValue = feeSchedule.FeeScheduleValue;
            ProductDesc = feeSchedule.ProductDesc;
            SetProduct(feeSchedule.Product);
        }
        public Guid FeeScheduleId { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime FeeScheduleStartDate { get; set; }
        public DateTime FeeScheduleEndDate { get; set; }
        public string FeeScheduleTypeCode { get; set; }
        public decimal FeeScheduleValue { get; set; }
        public string ProductDesc { get; set; }
        public ProductViewModel Product { get; set; } = new ProductViewModel();
        public void SetProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            Product = new ProductViewModel(product);
        }
    }
}


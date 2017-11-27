using QIQO.Business.Companies.Data.Entities;
using QIQO.Business.Core.Contracts;
using System;

namespace QIQO.Business.Companies.Models
{
    public class FeeSchedule : IModel
    {
        public FeeSchedule(FeeScheduleData feeScheduleData)
        {
            if (feeScheduleData == null) throw new ArgumentNullException(nameof(feeScheduleData));
            FeeScheduleId = feeScheduleData.FeeScheduleId;
            CompanyId = feeScheduleData.CompanyId;
            FeeScheduleStartDate = feeScheduleData.FeeScheduleStartDate;
            FeeScheduleEndDate = feeScheduleData.FeeScheduleEndDate;
            FeeScheduleTypeCode = feeScheduleData.FeeScheduleTypeCode;
            FeeScheduleValue = feeScheduleData.FeeScheduleValue;
            ProductDesc = feeScheduleData.ProductDesc;
            SetProduct(feeScheduleData.Product);
        }
        public FeeSchedule(FeeSchedule feeSchedule)
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
        public Guid FeeScheduleId { get; private set; }
        public Guid CompanyId { get; private set; }
        public DateTime FeeScheduleStartDate { get; private set; }
        public DateTime FeeScheduleEndDate { get; private set; }
        public string FeeScheduleTypeCode { get; private set; }
        public decimal FeeScheduleValue { get; private set; }
        public string ProductDesc { get; private set; }
        public Product Product { get; private set; } = new Product(new ProductData());

        public void SetProduct(ProductData productData)
        {
            if (productData == null) throw new ArgumentNullException(nameof(productData));
            Product = new Product(productData);
        }
        public void SetProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            Product = new Product(product);
        }
    }
}

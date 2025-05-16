using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.PaymentProvider.Models;
using AutoGenerator.Config;
using System;
using WasmAI.PaymentProvider.BPR.Layers.Base;

namespace WasmAI.PaymentProvider.DyModels.Dto.Build.ResponseFilters
{
    public class DiscountResponseFilterBuildDto : ITBuildDto
    {
        /// <summary>
        /// Id property for DTO.
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// CouponCode property for DTO.
        /// </summary>
        public String? CouponCode { get; set; }
        /// <summary>
        /// ExternalId property for DTO.
        /// </summary>
        public String? ExternalId { get; set; }
        /// <summary>
        /// AmountOff property for DTO.
        /// </summary>
        public Nullable<Decimal> AmountOff { get; set; }
        /// <summary>
        /// PercentOff property for DTO.
        /// </summary>
        public Nullable<Int32> PercentOff { get; set; }
        /// <summary>
        /// ExpiryDate property for DTO.
        /// </summary>
        public Nullable<DateTime> ExpiryDate { get; set; }
        /// <summary>
        /// MaxRedemptions property for DTO.
        /// </summary>
        public Nullable<Int32> MaxRedemptions { get; set; }
        /// <summary>
        /// TimesRedeemed property for DTO.
        /// </summary>
        public Int32 TimesRedeemed { get; set; }
        /// <summary>
        /// IsActive property for DTO.
        /// </summary>
        public Boolean IsActive { get; set; }
        /// <summary>
        /// CreatedAt property for DTO.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// CustomerId property for DTO.
        /// </summary>
        public Nullable<Guid> CustomerId { get; set; }
        public CustomerResponseFilterBuildDto? Customer { get; set; }

        [FilterLGEnabled]
        public string? Lg { get; set; }
    }
}
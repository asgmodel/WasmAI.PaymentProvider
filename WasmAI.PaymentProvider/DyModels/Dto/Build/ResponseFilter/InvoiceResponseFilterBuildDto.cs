using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.PaymentProvider.Models;
using AutoGenerator.Config;
using System;
using WasmAI.PaymentProvider.BPR.Layers.Base;

namespace WasmAI.PaymentProvider.DyModels.Dto.Build.ResponseFilters
{
    public class InvoiceResponseFilterBuildDto : ITBuildDto
    {
        /// <summary>
        /// Id property for DTO.
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// ExternalId property for DTO.
        /// </summary>
        public String? ExternalId { get; set; }
        /// <summary>
        /// CustomerId property for DTO.
        /// </summary>
        public Guid CustomerId { get; set; }
        public CustomerResponseFilterBuildDto? Customer { get; set; }
        /// <summary>
        /// Currency property for DTO.
        /// </summary>
        public String? Currency { get; set; }
        /// <summary>
        /// TotalAmount property for DTO.
        /// </summary>
        public Decimal TotalAmount { get; set; }
        /// <summary>
        /// Status property for DTO.
        /// </summary>
        public String? Status { get; set; }
        /// <summary>
        /// InvoiceDate property for DTO.
        /// </summary>
        public DateTime InvoiceDate { get; set; }
        /// <summary>
        /// DueDate property for DTO.
        /// </summary>
        public Nullable<DateTime> DueDate { get; set; }
        /// <summary>
        /// PaidAt property for DTO.
        /// </summary>
        public Nullable<DateTime> PaidAt { get; set; }
        /// <summary>
        /// Description property for DTO.
        /// </summary>
        public String? Description { get; set; }
        /// <summary>
        /// Number property for DTO.
        /// </summary>
        public String? Number { get; set; }
        public ICollection<InvoiceItemResponseFilterBuildDto>? Items { get; set; }

        [FilterLGEnabled]
        public string? Lg { get; set; }
    }
}
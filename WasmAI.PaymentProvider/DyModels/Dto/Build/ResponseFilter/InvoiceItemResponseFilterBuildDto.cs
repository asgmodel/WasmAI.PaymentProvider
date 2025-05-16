using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.PaymentProvider.Models;
using AutoGenerator.Config;
using System;
using WasmAI.PaymentProvider.BPR.Layers.Base;

namespace WasmAI.PaymentProvider.DyModels.Dto.Build.ResponseFilters
{
    public class InvoiceItemResponseFilterBuildDto : ITBuildDto
    {
        /// <summary>
        /// Id property for DTO.
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Description property for DTO.
        /// </summary>
        public String? Description { get; set; }
        /// <summary>
        /// Amount property for DTO.
        /// </summary>
        public Decimal Amount { get; set; }
        /// <summary>
        /// Quantity property for DTO.
        /// </summary>
        public Int32 Quantity { get; set; }
        /// <summary>
        /// Total property for DTO.
        /// </summary>
        public Decimal Total { get; set; }
        /// <summary>
        /// InvoiceId property for DTO.
        /// </summary>
        public Guid InvoiceId { get; set; }
        public InvoiceResponseFilterBuildDto? Invoice { get; set; }

        [FilterLGEnabled]
        public string? Lg { get; set; }
    }
}
using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.PaymentProvider.Models;
using AutoGenerator.Config;
using System;
using WasmAI.PaymentProvider.BPR.Layers.Base;

namespace WasmAI.PaymentProvider.DyModels.Dto.Build.Responses
{
    public class RefundResponseBuildDto : ITBuildDto
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
        /// PaymentId property for DTO.
        /// </summary>
        public Guid PaymentId { get; set; }
        public PaymentResponseBuildDto? Payment { get; set; }
        /// <summary>
        /// Amount property for DTO.
        /// </summary>
        public Decimal Amount { get; set; }
        /// <summary>
        /// Currency property for DTO.
        /// </summary>
        public String? Currency { get; set; }
        /// <summary>
        /// Status property for DTO.
        /// </summary>
        public String? Status { get; set; }
        /// <summary>
        /// Reason property for DTO.
        /// </summary>
        public String? Reason { get; set; }
        /// <summary>
        /// CreatedAt property for DTO.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// ProcessedAt property for DTO.
        /// </summary>
        public Nullable<DateTime> ProcessedAt { get; set; }
    }
}
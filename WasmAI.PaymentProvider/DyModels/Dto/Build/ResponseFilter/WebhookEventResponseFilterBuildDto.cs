using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.PaymentProvider.Models;
using AutoGenerator.Config;
using System;
using WasmAI.PaymentProvider.BPR.Layers.Base;

namespace WasmAI.PaymentProvider.DyModels.Dto.Build.ResponseFilters
{
    public class WebhookEventResponseFilterBuildDto : ITBuildDto
    {
        /// <summary>
        /// Id property for DTO.
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// EventId property for DTO.
        /// </summary>
        public String? EventId { get; set; }
        /// <summary>
        /// EventType property for DTO.
        /// </summary>
        public String? EventType { get; set; }
        /// <summary>
        /// Payload property for DTO.
        /// </summary>
        public String? Payload { get; set; }
        /// <summary>
        /// ProviderName property for DTO.
        /// </summary>
        public String? ProviderName { get; set; }
        /// <summary>
        /// ReceivedAt property for DTO.
        /// </summary>
        public DateTime ReceivedAt { get; set; }
        /// <summary>
        /// Processed property for DTO.
        /// </summary>
        public Boolean Processed { get; set; }
        /// <summary>
        /// ProcessedAt property for DTO.
        /// </summary>
        public Nullable<DateTime> ProcessedAt { get; set; }
        /// <summary>
        /// ProcessingError property for DTO.
        /// </summary>
        public String? ProcessingError { get; set; }

        [FilterLGEnabled]
        public string? Lg { get; set; }
    }
}
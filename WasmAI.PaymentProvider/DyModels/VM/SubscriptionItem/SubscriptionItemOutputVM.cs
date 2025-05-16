using AutoGenerator;
using AutoGenerator.Helper.Translation;
using WasmAI.PaymentProvider.Models;
using System;
using WasmAI.PaymentProvider.BPR.Layers.Base;

namespace WasmAI.PaymentProvider.DyModels.VMs
{
    /// <summary>
    /// SubscriptionItem  property for VM Output.
    /// </summary>
    public class SubscriptionItemOutputVM : ITVM
    {
        ///
        public Guid Id { get; set; }
        ///
        public String? ExternalId { get; set; }
        ///
        public Guid SubscriptionId { get; set; }
        public SubscriptionOutputVM? Subscription { get; set; }
        ///
        public String? PricePlanExternalId { get; set; }
        ///
        public Int32 Quantity { get; set; }
        ///
        public DateTime CreatedAt { get; set; }
    }
}
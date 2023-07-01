using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class TransactionSummaryV2
{
    public long Id { get; set; }

    public DateTime TranDate { get; set; }

    public DateTime? Utcdate { get; set; }

    public long? UserId { get; set; }

    public string? Username { get; set; }

    public string AccountLevel { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public string? Product { get; set; }

    public string? AccountProviderCode { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? TotalMerchantFees { get; set; }

    public decimal? TotalMasterFees { get; set; }

    public decimal? TotalApfees { get; set; }

    public decimal? TotalComFees { get; set; }

    public decimal? ComRate { get; set; }

    public decimal? Aprate { get; set; }

    public decimal? MasterRate { get; set; }

    public decimal? MerchantRate { get; set; }

    public decimal? PayinTotalAmount { get; set; }

    public decimal? PayinTotalMerchantFees { get; set; }

    public decimal? PayinTotalMasterFees { get; set; }

    public decimal? PayinTotalApfees { get; set; }

    public decimal? PayinTotalComFees { get; set; }

    public decimal? PayoutTotalAmount { get; set; }

    public decimal? PayoutTotalMerchantFees { get; set; }

    public decimal? PayoutTotalMasterFees { get; set; }

    public decimal? PayoutTotalApfees { get; set; }

    public decimal? PayoutTotalComFees { get; set; }

    public decimal? PromptPayTotalAmount { get; set; }

    public decimal? PromptPayTotalMerchantFees { get; set; }

    public decimal? PromptPayTotalMasterFees { get; set; }

    public decimal? PromptPayTotalApfees { get; set; }

    public decimal? PromptPayTotalComFees { get; set; }

    public decimal? UpitotalAmount { get; set; }

    public decimal? UpitotalMerchantFees { get; set; }

    public decimal? UpitotalMasterFees { get; set; }

    public decimal? UpitotalApfees { get; set; }

    public decimal? UpitotalComFees { get; set; }

    public decimal? ManualPayinTotalAmount { get; set; }

    public decimal? ManualPayinTotalMerchantFees { get; set; }

    public decimal? ManualPayinTotalMasterFees { get; set; }

    public decimal? ManualPayinTotalApfees { get; set; }

    public decimal? ManualPayinTotalComFees { get; set; }

    public decimal? DuitNowTotalAmount { get; set; }

    public decimal? DuitNowTotalMerchantFees { get; set; }

    public decimal? DuitNowTotalMasterFees { get; set; }

    public decimal? DuitNowTotalApfees { get; set; }

    public decimal? DuitNowTotalComFees { get; set; }

    public decimal? Balance { get; set; }

    public decimal? PayinComRate { get; set; }

    public decimal? PayinAprate { get; set; }

    public decimal? PayinMasterRate { get; set; }

    public decimal? PayinMerchantRate { get; set; }

    public decimal? PayoutComRate { get; set; }

    public decimal? PayoutAprate { get; set; }

    public decimal? PayoutMasterRate { get; set; }

    public decimal? PayoutMerchantRate { get; set; }

    public decimal? QrcomRate { get; set; }

    public decimal? Qraprate { get; set; }

    public decimal? QrmasterRate { get; set; }

    public decimal? QrmerchantRate { get; set; }

    public decimal? ManualPayinComRate { get; set; }

    public decimal? ManualPayinAprate { get; set; }

    public decimal? ManualPayinMasterRate { get; set; }

    public decimal? ManualPayinMerchantRate { get; set; }

    public string? PayinApcode { get; set; }

    public string? PayoutApcode { get; set; }

    public string? PromptPayApcode { get; set; }

    public string? Upiapcode { get; set; }

    public string? DuitNowApcode { get; set; }

    public string? ManualApcode { get; set; }

    public long? MasterId { get; set; }

    public string? Platform { get; set; }

    public DateTime CreatedDate { get; set; }
}

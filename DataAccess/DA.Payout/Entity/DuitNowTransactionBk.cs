using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class DuitNowTransactionBk
{
    public long Id { get; set; }

    public string MerchantCode { get; set; } = null!;

    public string RefId { get; set; } = null!;

    public string InvoiceNo { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public decimal? Amount { get; set; }

    public string BeneficiaryBankCode { get; set; } = null!;

    public string BeneficiaryAccount { get; set; } = null!;

    public string? BeneficiaryName { get; set; }

    public string? BeneficiaryMobile { get; set; }

    public string? BeneficiaryBankHash { get; set; }

    public string? Qrcode { get; set; }

    public string? Username { get; set; }

    public string UserIp { get; set; } = null!;

    public string? SenderMobile { get; set; }

    public string? SenderAddress { get; set; }

    public string? SenderName { get; set; }

    public string StatementDate { get; set; } = null!;

    public long? MerchantId { get; set; }

    public decimal? MerchantFees { get; set; }

    public decimal? MerchantMdrrate { get; set; }

    public long? MasterId { get; set; }

    public string? MasterCode { get; set; }

    public decimal? MasterFees { get; set; }

    public decimal? MasterMdrrate { get; set; }

    public long? AccountProviderId { get; set; }

    public string? AccountProviderCode { get; set; }

    public decimal? Apfees { get; set; }

    public decimal? ApcommisionRate { get; set; }

    public long? ComId { get; set; }

    public string? ComCode { get; set; }

    public decimal? ComCommision { get; set; }

    public decimal? ComCommisionRate { get; set; }

    public string? Reference { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class PayinFpxtransaction
{
    public long Id { get; set; }

    public string MerchantCode { get; set; } = null!;

    public string RefId { get; set; } = null!;

    public string InvoiceNo { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public decimal Amount { get; set; }

    public string? Description { get; set; }

    public string? ClientName { get; set; }

    public string? ClientPhone { get; set; }

    public string? ClientEmail { get; set; }

    public string? SenderBankCode { get; set; }

    public string? BeneficiaryBankCode { get; set; }

    public string? BeneficiaryAccountName { get; set; }

    public string? BeneficiaryAccount { get; set; }

    public string? BeneficiaryBankHash { get; set; }

    public string? HttppostUrl { get; set; }

    public string? FailedReturnUrl { get; set; }

    public string? ReturnUrl { get; set; }

    public string? MessageId { get; set; }

    public string? EndToEndId { get; set; }

    public string? TransactionId { get; set; }

    public bool? IsSubmitted { get; set; }

    public string? StatementDate { get; set; }

    public string? UserIp { get; set; }

    public string? UserCoordination { get; set; }

    public long? MerchantId { get; set; }

    public decimal? MerchantMdrrate { get; set; }

    public decimal? MerchantFees { get; set; }

    public long? MasterId { get; set; }

    public string? MasterCode { get; set; }

    public decimal? MasterMdrrate { get; set; }

    public decimal? MasterFees { get; set; }

    public long? AccountProviderId { get; set; }

    public string? AccountProviderCode { get; set; }

    public decimal? ApcommisionRate { get; set; }

    public decimal? Apfees { get; set; }

    public long? ComId { get; set; }

    public string? ComCode { get; set; }

    public decimal? ComCommisionRate { get; set; }

    public decimal? ComCommision { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedIp { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedIp { get; set; }

    public string? Token { get; set; }
}

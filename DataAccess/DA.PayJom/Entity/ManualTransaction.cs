using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class ManualTransaction
{
    public int Id { get; set; }

    public string MerchantCode { get; set; } = null!;

    public string MerchantBankCode { get; set; } = null!;

    public string MerchantAccount { get; set; } = null!;

    public string MerchantAccountName { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public DateTime BankStatementDate { get; set; }

    public decimal? TimeZone { get; set; }

    public string RefId { get; set; } = null!;

    public string? Description { get; set; }

    public string? ReceiverReference { get; set; }

    public decimal Amount { get; set; }

    public decimal? BalanceAfterCredit { get; set; }

    public string? SenderBankCode { get; set; }

    public string? SenderAccount { get; set; }

    public string? SenderAccountName { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public decimal? MerchantFees { get; set; }

    public decimal? MerchantMdrrate { get; set; }

    public decimal? MasterFees { get; set; }

    public decimal? MasterMdrrate { get; set; }

    public decimal? Apfees { get; set; }

    public decimal? ApcommisionRate { get; set; }

    public string? RawSenderAccount { get; set; }

    public string? BankHash { get; set; }

    public long? MerchantId { get; set; }

    public long? MasterId { get; set; }

    public string? MasterCode { get; set; }

    public long? AccountProviderId { get; set; }

    public string? AccountProviderCode { get; set; }

    public long? ComId { get; set; }

    public string? ComCode { get; set; }

    public decimal? ComCommision { get; set; }

    public decimal? ComCommisionRate { get; set; }
}

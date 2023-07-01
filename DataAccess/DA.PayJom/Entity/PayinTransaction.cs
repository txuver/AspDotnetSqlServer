using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class PayinTransaction
{
    public long Id { get; set; }

    public string MerchantCode { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public string InvoiceNo { get; set; } = null!;

    public decimal Amount { get; set; }

    public string? ItemId { get; set; }

    public string? ItemDescription { get; set; }

    public string? CompanyName { get; set; }

    public string? ClientName { get; set; }

    public string? ClientEmail { get; set; }

    public string? ClientPhone { get; set; }

    public string? SenderBankCode { get; set; }

    public string? SenderAccount { get; set; }

    public string? SenderAccountName { get; set; }

    public string? HttppostUrl { get; set; }

    public string? ReceiverBankCode { get; set; }

    public string? ReceiverAccount { get; set; }

    public string? ReceiverAccountName { get; set; }

    public string? Key { get; set; }

    public string? BankHash { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? StatementDate { get; set; }

    public long? MerchantId { get; set; }

    public decimal? MerchantMdrrate { get; set; }

    public decimal? MerchantFees { get; set; }

    public long? MasterId { get; set; }

    public string? MasterCode { get; set; }

    public decimal? MasterMdrrate { get; set; }

    public decimal? MasterCommision { get; set; }

    public long? AccountProviderId { get; set; }

    public string? AccountProviderCode { get; set; }

    public decimal? ApcommisionRate { get; set; }

    public decimal? Apcommision { get; set; }

    public long? ComId { get; set; }

    public string? ComCode { get; set; }

    public decimal? ComCommisionRate { get; set; }

    public decimal? ComCommision { get; set; }

    public string? IpAddress { get; set; }

    public virtual ICollection<PayinTransactionExtraInfo> PayinTransactionExtraInfos { get; set; } = new List<PayinTransactionExtraInfo>();
}

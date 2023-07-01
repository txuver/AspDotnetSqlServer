using System;
using System.Collections.Generic;

namespace DA.Qr;

public partial class ViewTransactionTransactionStatusUat
{
    public long Id { get; set; }

    public string MerchantCode { get; set; } = null!;

    public string RefId { get; set; } = null!;

    public string? Username { get; set; }

    public string UserIp { get; set; } = null!;

    public string BeneficiaryAccount { get; set; } = null!;

    public string? BeneficiaryName { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string BankCode { get; set; } = null!;

    public decimal? Amount { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public bool? IsManual { get; set; }

    public int? AccountType { get; set; }

    public string? Ifsc { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? MerchantBankCode { get; set; }

    public string? MerchantAccount { get; set; }

    public string TransactionCreatedBy { get; set; } = null!;

    public DateTime TransactionCreatedDate { get; set; }

    public string? TransactionStatusCreatedBy { get; set; }

    public DateTime? TransactionStatusCreatedDate { get; set; }

    public string? SenderMobile { get; set; }

    public string StatementDate { get; set; } = null!;

    public decimal? MerchantFees { get; set; }

    public decimal? MerchantMdrrate { get; set; }

    public decimal? MasterFees { get; set; }

    public decimal? MasterMdrrate { get; set; }

    public decimal? Apfees { get; set; }

    public decimal? ApcommisionRate { get; set; }

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

    public int? TxnType { get; set; }

    public string? Qrcode { get; set; }

    public string? PromptPayId { get; set; }

    public decimal? OriginalAmount { get; set; }

    public string? SenderAddress { get; set; }

    public string? SenderName { get; set; }

    public string? Attachments { get; set; }

    public int? TransactionStatus { get; set; }

    public string? ClientIp { get; set; }

    public string? StatusMessage { get; set; }

    public string? Remark { get; set; }

    public string? ErrorMessage { get; set; }

    public string? ReferenceType { get; set; }

    public string? TransactionUpdatedBy { get; set; }

    public DateTime? TransactionUpdatedDate { get; set; }

    public string? TransactionReference { get; set; }

    public string? TransactionStatusUpdatedBy { get; set; }

    public DateTime? TransactionStatusUpdatedDate { get; set; }

    public string? TransactionStatusReference { get; set; }

    public long? TransactionStatusId { get; set; }

    public int? TransactionType { get; set; }
}

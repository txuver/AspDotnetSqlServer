using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class PayoutTransactionEnter
{
    public long Id { get; set; }

    public string RefId { get; set; } = null!;

    public string? InvoiceNo { get; set; }

    public string Currency { get; set; } = null!;

    public decimal Amount { get; set; }

    public string MerchantCode { get; set; } = null!;

    public long MerchantId { get; set; }

    public string? Username { get; set; }

    public string UserIp { get; set; } = null!;

    public string? BeneficiaryBankCode { get; set; }

    public string? BeneficiaryAccount { get; set; }

    public string? BeneficiaryName { get; set; }

    public string? MasterCode { get; set; }

    public long? MasterId { get; set; }

    public string? AccountProviderCode { get; set; }

    public long? AccountProviderId { get; set; }

    public string? ComCode { get; set; }

    public long? ComId { get; set; }

    public int? TxnType { get; set; }

    public string? Status { get; set; }

    public string? StatusMessage { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }
}

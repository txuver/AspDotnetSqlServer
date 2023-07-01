using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class MerchantWallet
{
    public long Id { get; set; }

    public string MerchantCode { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public string TxnType { get; set; } = null!;

    public decimal TxnAmount { get; set; }

    public decimal RunningBalance { get; set; }

    public string? Reference { get; set; }

    public string? InvoiceNo { get; set; }

    public string? RefId { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Remark3 { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }
}

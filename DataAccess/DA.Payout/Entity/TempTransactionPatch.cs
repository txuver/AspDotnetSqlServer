using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class TempTransactionPatch
{
    public long RunId { get; set; }

    public long TransactionId { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public int? TxnType { get; set; }

    public long TransactionStatusId { get; set; }

    public long PayoutTransactionId { get; set; }

    public int? TransactionStatus { get; set; }

    public DateTime UpdatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public string? StatusMessage { get; set; }

    public string? Remark { get; set; }

    public string? ErrorMessage { get; set; }

    public string? Reference { get; set; }

    public string? ReferenceType { get; set; }
}

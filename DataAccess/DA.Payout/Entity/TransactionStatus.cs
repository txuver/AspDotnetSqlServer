using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class TransactionStatus
{
    public long Id { get; set; }

    public long PayoutTransactionId { get; set; }

    public int? TransactionStatus1 { get; set; }

    public string? ClientIp { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public string? StatusMessage { get; set; }

    public string? Remark { get; set; }

    public string? ErrorMessage { get; set; }

    public string? Reference { get; set; }

    public string? ReferenceType { get; set; }
}

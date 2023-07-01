using System;
using System.Collections.Generic;

namespace DA.Qr;

public partial class PromptPayTransactionStatus
{
    public long Id { get; set; }

    public long PromptPayTransactionId { get; set; }

    public int? TransactionStatus { get; set; }

    public string? StatusMessage { get; set; }

    public string? Remark { get; set; }

    public string? ErrorMessage { get; set; }

    public string? Reference { get; set; }

    public string? ReferenceType { get; set; }

    public string? ClientIp { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class PayinTransactionStatus
{
    public long Id { get; set; }

    public long PayinTransactionId { get; set; }

    public int? TransactionStatus { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public string? StatusMessage { get; set; }

    public string? Remark { get; set; }

    public string? BankReference { get; set; }
}

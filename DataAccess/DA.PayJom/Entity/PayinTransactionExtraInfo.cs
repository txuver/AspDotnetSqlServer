using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class PayinTransactionExtraInfo
{
    public long Id { get; set; }

    public long PayinTransactionId { get; set; }

    public string? ActualSenderName { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int? TxnType { get; set; }

    public virtual PayinTransaction PayinTransaction { get; set; } = null!;
}

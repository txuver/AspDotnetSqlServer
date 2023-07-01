using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class TransactionOverrideLog
{
    public long Id { get; set; }

    public string InvoiveNo { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTimeOffset? CreatedDate { get; set; }

    public string CreatedIp { get; set; } = null!;

    public int? Product { get; set; }

    public string? CurrencyCode { get; set; }

    public string? Action { get; set; }
}

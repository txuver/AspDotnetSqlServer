using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class TraceLog
{
    public int Index { get; set; }

    public DateTime? DateTime { get; set; }

    public string? Fi { get; set; }

    public string? PayeeId { get; set; }

    public string? Field { get; set; }

    public string? Data { get; set; }

    public string? InvoiceNo { get; set; }
}

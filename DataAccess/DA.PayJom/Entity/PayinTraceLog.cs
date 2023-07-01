using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class PayinTraceLog
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? CreatedDateUtc { get; set; }

    public string? Fi { get; set; }

    public string? PayeeId { get; set; }

    public string? Field { get; set; }

    public string? Data { get; set; }

    public string? InvoiceNo { get; set; }
}

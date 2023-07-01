using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class PayDirectCallbackLog
{
    public long Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? MerchantCode { get; set; }

    public string? RefId { get; set; }

    public string? InvoiceNo { get; set; }

    public int? TransactionStatus { get; set; }

    public string Operation { get; set; } = null!;

    public string RequestUrl { get; set; } = null!;

    public string Parameter { get; set; } = null!;

    public short StatusCode { get; set; }

    public string StatusMessage { get; set; } = null!;

    public string Response { get; set; } = null!;

    public int? Action { get; set; }
}

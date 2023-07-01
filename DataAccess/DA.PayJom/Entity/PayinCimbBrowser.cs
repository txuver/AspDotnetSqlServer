using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class PayinCimbBrowser
{
    public long Id { get; set; }

    public string BrowserId { get; set; } = null!;

    public string? InvoiceNo { get; set; }

    public string? ProxyIp { get; set; }
}

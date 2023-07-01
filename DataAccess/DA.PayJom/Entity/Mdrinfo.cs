using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class Mdrinfo
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string UserCode { get; set; } = null!;

    public string AccountLevel { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public int Platform { get; set; }

    public string PlatformName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}

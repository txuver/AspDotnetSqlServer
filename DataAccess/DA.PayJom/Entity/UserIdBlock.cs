using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class UserIdBlock
{
    public long Id { get; set; }

    public string Product { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string MerchantName { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public bool Blocked { get; set; }

    public string? Comment { get; set; }

    public string? UpdatedBy { get; set; }

    public string UpdatedIp { get; set; } = null!;
}

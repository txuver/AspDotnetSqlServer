using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class MerchantsAccountProvidersPayout
{
    public long Id { get; set; }

    public long MerchantUserId { get; set; }

    public long AccountProviderUserId { get; set; }

    public string Currency { get; set; } = null!;

    public byte Priority { get; set; }

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}

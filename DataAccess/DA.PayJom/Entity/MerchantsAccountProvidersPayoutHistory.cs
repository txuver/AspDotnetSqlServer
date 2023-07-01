using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class MerchantsAccountProvidersPayoutHistory
{
    public long Id { get; set; }

    public long MerchantUserId { get; set; }

    public long AccountProviderUserId { get; set; }

    public string Currency { get; set; } = null!;

    public byte Priority { get; set; }

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public string? UpdatedIp { get; set; }
}

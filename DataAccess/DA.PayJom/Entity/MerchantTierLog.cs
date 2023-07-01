using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class MerchantTierLog
{
    public long Id { get; set; }

    public long MerchantUserId { get; set; }

    public long TierSettingId { get; set; }

    public byte CurrentTier { get; set; }

    public decimal CurrentVolume { get; set; }

    public decimal TransAmount { get; set; }

    public string Currency { get; set; } = null!;

    public decimal Mdrrate { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}

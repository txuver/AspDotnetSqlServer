using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class MasterMdrdefaultSetting
{
    public long Id { get; set; }

    public long MasterUserId { get; set; }

    public byte Type { get; set; }

    public string Currency { get; set; } = null!;

    public long MasterMdrsettingId { get; set; }

    public long MerchantMdrsettingId { get; set; }

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}

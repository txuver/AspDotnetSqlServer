using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class MasterApdefaultSetting
{
    public long Id { get; set; }

    public long MasterUserId { get; set; }

    public long AccountProviderUserId { get; set; }

    public long Priority { get; set; }

    public byte Type { get; set; }

    public string Currency { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}

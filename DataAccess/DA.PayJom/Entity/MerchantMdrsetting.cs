using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class MerchantMdrsetting
{
    public long Id { get; set; }

    public long MerchantUserId { get; set; }

    public byte Type { get; set; }

    public string Currency { get; set; } = null!;

    public long MdrsettingId { get; set; }

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}

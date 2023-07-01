using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class RebateUserTier
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string Username { get; set; } = null!;

    public string AccountLevel { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public int Product { get; set; }

    public int Tier { get; set; }

    public decimal? Mdrrate { get; set; }

    public decimal? VolumeFrom { get; set; }

    public decimal? VolumeTo { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? CreatedIp { get; set; }

    public string? UpdatedBy { get; set; }

    public string UpdatedIp { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class RebateRequestTier
{
    public long Id { get; set; }

    public long RebateRequestId { get; set; }

    public int Tier { get; set; }

    public decimal? PayinRate { get; set; }

    public decimal? Qrrate { get; set; }

    public decimal? PayoutRate { get; set; }

    public decimal? VolumeFrom { get; set; }

    public decimal? VolumeTo { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? CreatedIp { get; set; }

    public string? UpdatedBy { get; set; }

    public string UpdatedIp { get; set; } = null!;
}

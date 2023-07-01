using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class RebateRequest
{
    public long Id { get; set; }

    public string? RefId { get; set; }

    public long UserId { get; set; }

    public string Username { get; set; } = null!;

    public string AccountLevel { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public long RebateType { get; set; }

    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

    public decimal? PayinVolume { get; set; }

    public decimal? Qrvolume { get; set; }

    public decimal? PayoutVolume { get; set; }

    public decimal? TotalRebateAmount { get; set; }

    public string? PayinRebateTier { get; set; }

    public string? PayinRebateRate { get; set; }

    public string? PayinRebateAmount { get; set; }

    public string? PayoutRebateTier { get; set; }

    public string? PayoutRebateRate { get; set; }

    public string? PayoutRebateAmount { get; set; }

    public string? QrrebateTier { get; set; }

    public string? QrrebateRate { get; set; }

    public string? QrrebateAmount { get; set; }

    public string? Remark { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? CreatedIp { get; set; }

    public string? UpdatedBy { get; set; }

    public string UpdatedIp { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class SettlementFeeSetting
{
    public int Id { get; set; }

    public string? AccountProviderCode { get; set; }

    public string Currency { get; set; } = null!;

    public string SettlementFeeType { get; set; } = null!;

    public decimal? SettlementFeePercent { get; set; }

    public int? Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;
}

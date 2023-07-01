using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class SettlementSetting
{
    public long Id { get; set; }

    public decimal SettlementFeeMyr { get; set; }

    public decimal SettlementFeeThb { get; set; }

    public decimal SettlementFeeInr { get; set; }

    public DateTimeOffset? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public decimal? SettlementFeeVnd { get; set; }
}

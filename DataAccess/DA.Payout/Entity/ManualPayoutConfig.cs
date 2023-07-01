using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class ManualPayoutConfig
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string Username { get; set; } = null!;

    public long? ParentUserId { get; set; }

    public string? ParentUsername { get; set; }

    public string? AccountLevel { get; set; }

    public bool? IsWholeLineApply { get; set; }

    public bool? IsDeductWallet { get; set; }

    public bool? IsMinMaxLimit { get; set; }

    public bool? IsDailyLimit { get; set; }

    public bool? IsNoSenderBank { get; set; }

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}

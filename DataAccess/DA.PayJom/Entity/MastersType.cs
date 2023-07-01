using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class MastersType
{
    public long Id { get; set; }

    public long MasterUserId { get; set; }

    public byte Type { get; set; }

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }

    public bool? IsEnableBankBot { get; set; }

    public bool? IsEnablePromptPay { get; set; }

    public bool? IsEnableUpi { get; set; }

    public bool? IsEnableDuitNow { get; set; }
}

using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class MerchantType
{
    public long Id { get; set; }

    public long MerchantUserId { get; set; }

    public byte Type { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }

    public bool? IsEnablePromptPay { get; set; }

    public bool? IsEnableUpi { get; set; }

    public bool? IsEnableDuitNow { get; set; }
}

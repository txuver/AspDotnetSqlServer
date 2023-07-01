using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class AccountProvidersType
{
    public long Id { get; set; }

    public long AccountProviderUserId { get; set; }

    public byte Type { get; set; }

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }

    public bool? IsPromptPay { get; set; }

    public bool? IsUpi { get; set; }

    public bool? IsDuitNow { get; set; }
}

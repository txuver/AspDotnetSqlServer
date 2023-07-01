using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class SenderBankInfo
{
    public long Id { get; set; }

    public string SenderBankCode { get; set; } = null!;

    public string SenderMobile { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }

    public string? SenderCode { get; set; }
}

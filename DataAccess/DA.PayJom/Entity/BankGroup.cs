using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class BankGroup
{
    public long Id { get; set; }

    public string GroupName { get; set; } = null!;

    public long OwnerId { get; set; }

    public string? Remark { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }

    public int? Status { get; set; }
}

using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class AuditTrail
{
    public long Id { get; set; }

    public string Username { get; set; } = null!;

    public string Module { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? UserIp { get; set; }

    public DateTime CreatedDate { get; set; }
}

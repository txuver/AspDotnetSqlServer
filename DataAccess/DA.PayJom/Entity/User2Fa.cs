using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class User2Fa
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public long VersionCode { get; set; }

    public bool IsEnable2Fa { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public string? UpdatedIp { get; set; }

    public bool? IsSubAccount { get; set; }
}

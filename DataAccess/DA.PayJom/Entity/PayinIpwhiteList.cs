using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class PayinIpwhiteList
{
    public long UserId { get; set; }

    public string Ipaddress { get; set; } = null!;

    public bool IsActive { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTimeOffset CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTimeOffset? UpdatedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ClientIp { get; set; }
}

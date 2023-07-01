using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class SubAccountAccessRight
{
    public long Id { get; set; }

    public long SubAccountId { get; set; }

    public long RoleId { get; set; }

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}

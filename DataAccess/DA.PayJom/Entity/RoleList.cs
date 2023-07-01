using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class RoleList
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string RoleName { get; set; } = null!;

    public bool Status { get; set; }

    public string? Description { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}

using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class RoleModuleAccessRight
{
    public long Id { get; set; }

    public long RoleId { get; set; }

    public long ModuleId { get; set; }

    public long AccessRightId { get; set; }

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}

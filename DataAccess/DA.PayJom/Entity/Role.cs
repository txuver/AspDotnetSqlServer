using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class Role
{
    public Guid RoleId { get; set; }

    public Guid ApplicationId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual Application Application { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

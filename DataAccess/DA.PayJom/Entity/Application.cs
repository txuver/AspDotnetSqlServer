using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class Application
{
    public Guid ApplicationId { get; set; }

    public string ApplicationName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Membership> Memberships { get; set; } = new List<Membership>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

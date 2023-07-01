using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class User
{
    public Guid UserId { get; set; }

    public Guid ApplicationId { get; set; }

    public string UserName { get; set; } = null!;

    public bool IsAnonymous { get; set; }

    public DateTime LastActivityDate { get; set; }

    public virtual Application Application { get; set; } = null!;

    public virtual Membership? Membership { get; set; }

    public virtual Profile? Profile { get; set; }

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}

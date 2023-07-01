using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class SubAccount
{
    public long Id { get; set; }

    public long ParentUserId { get; set; }

    public string ParentUsername { get; set; } = null!;

    public string? Username { get; set; }

    public string? Alias { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public bool Status { get; set; }

    public bool? Lock { get; set; }

    public string? LastLoginIp { get; set; }

    public string CreatedIp { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTimeOffset CreatedDate { get; set; }

    public string? UpdatedIp { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTimeOffset? UpdatedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class UserSiteConfig
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string Type { get; set; } = null!;

    public string SubType { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string Data { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? Public { get; set; }

    public string? Comment { get; set; }

    public string? Help { get; set; }
}

using System;
using System.Collections.Generic;

namespace DA.Accounting;

public partial class UserActionLog
{
    public long Id { get; set; }

    public string? FromUser { get; set; }

    public string? ToUser { get; set; }

    public string Content { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}

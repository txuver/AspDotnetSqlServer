using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class AccessRight
{
    public long Id { get; set; }

    public string AccessRightName { get; set; } = null!;

    public bool Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTimeOffset? CreatedDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class Module
{
    public long Id { get; set; }

    public string MainModuleName { get; set; } = null!;

    public string ModuleName { get; set; } = null!;

    public bool Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTimeOffset? CreatedDate { get; set; }
}

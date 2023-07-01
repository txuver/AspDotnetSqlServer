using System;
using System.Collections.Generic;

namespace DA.Accounting;

public partial class PagePermission
{
    public long Id { get; set; }

    public long MemberId { get; set; }

    public string PageCode { get; set; } = null!;

    public bool IsView { get; set; }

    public bool IsCreate { get; set; }

    public bool IsEdit { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }
}

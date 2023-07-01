using System;
using System.Collections.Generic;

namespace DA.Accounting;

public partial class Group
{
    public long Id { get; set; }

    public long MemberId { get; set; }

    public string? GroupName { get; set; }

    public string? GroupDesc { get; set; }

    public int Status { get; set; }

    public DateTime CreatedDate { get; set; }
}

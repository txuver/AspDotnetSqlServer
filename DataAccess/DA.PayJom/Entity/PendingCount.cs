using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class PendingCount
{
    public long Id { get; set; }

    public string Username { get; set; } = null!;

    public string Product { get; set; } = null!;

    public long Count { get; set; }

    public long LatestId { get; set; }

    public DateTime CreatedDate { get; set; }
}

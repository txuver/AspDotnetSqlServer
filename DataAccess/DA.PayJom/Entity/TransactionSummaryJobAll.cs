using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class TransactionSummaryJobAll
{
    public long Id { get; set; }

    public DateTime RerunSummaryDate { get; set; }

    public string Username { get; set; } = null!;

    public string AccountLevel { get; set; } = null!;

    public short? IsUpdate { get; set; }

    public DateTime CreatedDate { get; set; }
}

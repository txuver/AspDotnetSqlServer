using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class TransactionSummaryAllSetting
{
    public long Id { get; set; }

    public DateTime LastRunDate { get; set; }

    public string UpdateBy { get; set; } = null!;

    public string AccountLevel { get; set; } = null!;

    public DateTime? UpdatedDate { get; set; }
}

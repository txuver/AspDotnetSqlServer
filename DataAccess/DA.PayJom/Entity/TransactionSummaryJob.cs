using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class TransactionSummaryJob
{
    public long Id { get; set; }

    public DateTime RerunSummaryDate { get; set; }

    public string MerchantCode { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}

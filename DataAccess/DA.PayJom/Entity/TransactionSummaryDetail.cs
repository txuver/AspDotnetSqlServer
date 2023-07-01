using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class TransactionSummaryDetail
{
    public long Id { get; set; }

    public long TransactionSummaryId { get; set; }

    public long UserId { get; set; }

    public string? Username { get; set; }

    public string? AccountLevel { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? TotalFees { get; set; }

    public long? ParentId { get; set; }

    public DateTime CreatedDate { get; set; }
}

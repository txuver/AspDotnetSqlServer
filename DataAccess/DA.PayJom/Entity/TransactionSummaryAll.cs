using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class TransactionSummaryAll
{
    public long Id { get; set; }

    public DateTime TranDate { get; set; }

    public long? UserId { get; set; }

    public string Username { get; set; } = null!;

    public string AccountLevel { get; set; } = null!;

    public string Product { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public decimal? TotalAmount { get; set; }

    public decimal? TotalFees { get; set; }

    public DateTime CreatedDate { get; set; }
}

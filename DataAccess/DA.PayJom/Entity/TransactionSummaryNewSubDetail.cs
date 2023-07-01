using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class TransactionSummaryNewSubDetail
{
    public long Id { get; set; }

    public DateTime TransDate { get; set; }

    public long UserId { get; set; }

    public string Username { get; set; } = null!;

    public long? AccountProviderId { get; set; }

    public string? AccountProviderCode { get; set; }

    public string Product { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public string AccountLevel { get; set; } = null!;

    public decimal? TotalAmount { get; set; }

    public decimal? Apfees { get; set; }
}

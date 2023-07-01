using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class TransactionSummaryNew
{
    public long Id { get; set; }

    public DateTime TransDate { get; set; }

    public long? Comid { get; set; }

    public string? Comcode { get; set; }

    public long? MasterId { get; set; }

    public string? MasterCode { get; set; }

    public string Product { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public string AccountLevel { get; set; } = null!;

    public decimal? TotalAmount { get; set; }

    public decimal? MasterFees { get; set; }
}

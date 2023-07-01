using System;
using System.Collections.Generic;

namespace DA.Payout;

public partial class CountryNo
{
    public long Id { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }
}

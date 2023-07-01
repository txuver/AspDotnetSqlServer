using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class CurrencyRate
{
    public long Id { get; set; }

    public string CurrencyFrom { get; set; } = null!;

    public string CurrencyTo { get; set; } = null!;

    public decimal? Rate { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }
}

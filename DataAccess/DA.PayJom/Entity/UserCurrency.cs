using System;
using System.Collections.Generic;

namespace DA.PayJom;

public partial class UserCurrency
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedIp { get; set; }

    public decimal? TimeZoneHour { get; set; }
}
